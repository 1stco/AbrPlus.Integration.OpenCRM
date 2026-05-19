using AbrPlus.Integration.OpenCRM.Enums;
using AbrPlus.Integration.OpenCRM.Requests;
using AbrPlus.Integration.OpenCRM.Responses;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AbrPlus.Integration.OpenCRM.Client.JsonRPC
{
    public class CallStoreJsonRPCClient : ICallStoreApiClient, IDisposable
    {
        private static readonly Lazy<HttpClient> SharedHttpClient = new Lazy<HttpClient>(CreateSharedHttpClient);

        private readonly HttpClient _httpClient;
        private readonly bool _disposeHttpClient;
        private bool _disposed;

        protected string Host { get; private set; }
        protected string Username { get; private set; }
        protected string Password { get; private set; }
        protected AuthType AuthType { get; private set; }

        public virtual string CallStoreId { get; private set; }

        public CallStoreJsonRPCClient(string callStoreId, string host, string username, string password, AuthType authType)
            : this(SharedHttpClient.Value, disposeHttpClient: false, callStoreId: callStoreId, host: host, username: username, password: password, authType: authType)
        {
        }

        public CallStoreJsonRPCClient(HttpClient httpClient, string callStoreId, string host, string username, string password, AuthType authType)
            : this(httpClient, disposeHttpClient: false, callStoreId: callStoreId, host: host, username: username, password: password, authType: authType)
        {
        }

        public CallStoreJsonRPCClient(HttpMessageHandler httpMessageHandler, string callStoreId, string host, string username, string password, AuthType authType)
            : this(new HttpClient(httpMessageHandler, disposeHandler: true), disposeHttpClient: true, callStoreId: callStoreId, host: host, username: username, password: password, authType: authType)
        {
        }

        protected CallStoreJsonRPCClient(HttpClient httpClient, bool disposeHttpClient, string callStoreId, string host, string username, string password, AuthType authType)
        {
            if (httpClient == null)
                throw new ArgumentNullException(nameof(httpClient));

            if (string.IsNullOrWhiteSpace(host))
                throw new ArgumentNullException(nameof(host));

            _httpClient = httpClient;
            _disposeHttpClient = disposeHttpClient;

            CallStoreId = callStoreId;
            Host = host.TrimEnd('/');
            Username = username;
            Password = password;
            AuthType = authType;
        }

        private static HttpClient CreateSharedHttpClient()
        {
            var client = new HttpClient();
            client.Timeout = TimeSpan.FromSeconds(30);
            return client;
        }
        public Task<CallCreateResponse> CallCreated(CallCreateRequest callCreateRequest)
        {
            return SendAsync<CallCreateRequest, CallCreateResponse>(
                "call",
                "created",
                callCreateRequest,
                CancellationToken.None);
        }

        public Task<CallUpdateResponse> CallUpdated(CallUpdateRequest callUpdateRequest)
        {
            return SendAsync<CallUpdateRequest, CallUpdateResponse>(
                "call",
                "updated",
                callUpdateRequest,
                CancellationToken.None);
        }

        public Task<CallChannelCreateResponse> CallChannelCreated(CallChannelCreateRequest callChannelCreateRequest)
        {
            return SendAsync<CallChannelCreateRequest, CallChannelCreateResponse>(
                "call",
                "channelCreated",
                callChannelCreateRequest,
                CancellationToken.None);
        }

        public Task<CallChannelUpdateResponse> CallChannelUpdated(CallChannelUpdateRequest callChannelUpdateRequest)
        {
            return SendAsync<CallChannelUpdateRequest, CallChannelUpdateResponse>(
                "call",
                "channelUpdated",
                callChannelUpdateRequest,
                CancellationToken.None);
        }

        public Task<MergeCallResponse> MergeCall(MergeCallRequest mergeCallRequest)
        {
            return SendAsync<MergeCallRequest, MergeCallResponse>(
                "call",
                "merge",
                mergeCallRequest,
                CancellationToken.None);
        }
        protected virtual async Task<TResponse> SendAsync<TRequest, TResponse>(
            string category,
            string method,
            TRequest parameters,
            CancellationToken cancellationToken = default)
        {
            ThrowIfDisposed();

            if (string.IsNullOrWhiteSpace(method))
                throw new ArgumentNullException(nameof(method));

            if (!string.IsNullOrWhiteSpace(category))
                method = $"{category}_{method}";

            var rpcRequest = new JsonRpcRequest<TRequest>
            {
                Id = Guid.NewGuid().ToString("N"),
                Method = method,
                Params = parameters
            };

            using (var httpRequest = new HttpRequestMessage(HttpMethod.Post, Host))
            {
                httpRequest.Content = JsonContentFactory.Create(rpcRequest);

                ApplyAuthentication(httpRequest);

                using (var httpResponse = await _httpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false))
                {
                    var responseBody = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);

                    if (!httpResponse.IsSuccessStatusCode)
                    {
                        throw new CallStoreHttpException(httpResponse.StatusCode, responseBody);
                    }

                    JsonRpcResponse<TResponse> rpcResponse;

                    try
                    {
                        rpcResponse = JsonContentFactory.Deserialize<JsonRpcResponse<TResponse>>(responseBody);
                    }
                    catch (Exception ex)
                    {
                        throw new CallStoreInvalidJsonException(responseBody, ex);
                    }

                    if (rpcResponse == null)
                    {
                        throw new CallStoreInvalidJsonException(responseBody);
                    }

                    if (rpcResponse.Error != null)
                    {
                        throw new CallStoreJsonRpcException(rpcResponse.Error.Code, rpcResponse.Error.Message, rpcResponse.Error.Data, rpcResponse.Id);
                    }

                    if (rpcResponse.Result == null)
                    {
                        throw new CallStoreInvalidJsonRpcResponseException("JSON-RPC response does not contain result.", responseBody);
                    }

                    return rpcResponse.Result;
                }
            }
        }

        protected virtual void ApplyAuthentication(HttpRequestMessage request)
        {
            if (AuthType == AuthType.Basic)
            {
                var raw = string.Format("{0}:{1}", Username, Password);
                var encoded = Convert.ToBase64String(Encoding.ASCII.GetBytes(raw));

                request.Headers.Authorization = new AuthenticationHeaderValue("Basic", encoded);
            }
        }

        protected void ThrowIfDisposed()
        {
            if (_disposed)
                throw new ObjectDisposedException(GetType().FullName);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                if (_disposeHttpClient)
                {
                    _httpClient.Dispose();
                }
            }

            _disposed = true;
        }
    }
}