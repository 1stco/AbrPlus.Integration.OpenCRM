using AbrPlus.Integration.OpenCRM.Enums;
using AbrPlus.Integration.OpenCRM.Requests;
using AbrPlus.Integration.OpenCRM.Responses;
using AbrPlus.Platform.Client;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AbrPlus.Integration.OpenCRM.Client.JsonRPC
{
    public class CallStoreJsonRPCClient : ICallStoreApiClient, IDisposable
    {
        private readonly ApiClientHandler _handler;
        private bool _disposed;

        protected string Host { get; }
        public virtual string CallStoreId { get; }
        public virtual string CallStoreName { get; }

        public CallStoreJsonRPCClient(string callStoreId, string callStoreName, string host, string username, string password, AuthType authType, ILoggerFactory loggerFactory = null)
            : this(callStoreId, callStoreName, host)
        {
            switch (authType)
            {
                case AuthType.None:
                    break;
                case AuthType.Basic:
                    var credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));
                    _handler = new ApiClientHandler(new BasicAuthorize { PrecomputedHeader = credentials }, loggerFactory ?? NullLoggerFactory.Instance);
                    break;
                default:
                    throw new ArgumentException("Use the constructor that accepts the authorization settings for this mode.", nameof(authType));
            }
        }

        public CallStoreJsonRPCClient(string callStoreId, string callStoreName, string host, BasicAuthorize auth, ILoggerFactory loggerFactory = null)
            : this(callStoreId, callStoreName, host)
        {
            if (auth == null)
                throw new ArgumentNullException(nameof(auth));

            _handler = new ApiClientHandler(auth, loggerFactory ?? NullLoggerFactory.Instance);
        }

        public CallStoreJsonRPCClient(string callStoreId, string callStoreName, string host, PublicPasswordFlowAutorize auth, ILoggerFactory loggerFactory = null)
            : this(callStoreId, callStoreName, host)
        {
            if (auth == null)
                throw new ArgumentNullException(nameof(auth));

            _handler = new ApiClientHandler(auth, loggerFactory ?? NullLoggerFactory.Instance);
        }

        public CallStoreJsonRPCClient(string callStoreId, string callStoreName, string host, BearerAuthorize auth, ILoggerFactory loggerFactory = null)
            : this(callStoreId, callStoreName, host)
        {
            if (auth == null)
                throw new ArgumentNullException(nameof(auth));

            _handler = new ApiClientHandler(auth, loggerFactory ?? NullLoggerFactory.Instance);
        }

        public CallStoreJsonRPCClient(string callStoreId, string callStoreName, string host, ApiKeyAuthorize auth, ILoggerFactory loggerFactory = null)
            : this(callStoreId, callStoreName, host)
        {
            if (auth == null)
                throw new ArgumentNullException(nameof(auth));

            _handler = new ApiClientHandler(auth, loggerFactory ?? NullLoggerFactory.Instance);
        }

        private CallStoreJsonRPCClient(string callStoreId, string callStoreName, string host)
        {
            if (string.IsNullOrWhiteSpace(host))
                throw new ArgumentNullException(nameof(host));

            CallStoreId = callStoreId;
            Host = host.TrimEnd('/');
            CallStoreName = callStoreName;
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
        public Task<string> GetCallerIdName(string phoneNumber)
        {
            return SendAsync<object, string>(
                "call", 
                "callerIdName", 
                new { phoneNumber }, 
                CancellationToken.None);
        }

        public Task<string> GetProfileUrlFormat()
        {
            return SendAsync<object, string>(
                "call", 
                "profileUrlFormat", 
                null, 
                CancellationToken.None);
        }

        protected virtual async Task<TResponse> SendAsync<TRequest, TResponse>(
            string category,
            string method,
            TRequest parameters,
            CancellationToken cancellationToken = default)
        {
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

                using (var httpClient = CreateClient())
                {
                    using (var httpResponse = await httpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false))
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
        }

        protected virtual HttpClient CreateClient()
        {
            if (_disposed)
                throw new ObjectDisposedException(GetType().Name);

            return _handler == null ? new HttpClient() : new HttpClient(_handler, disposeHandler: false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing || _disposed)
                return;

            _disposed = true;

            // ApiClientHandler 1.1.26 leaves disposal of its transport to the owner.
            _handler?.InnerHandler?.Dispose();
            _handler?.Dispose();
        }
    }
}
