using AbrPlus.Integration.OpenCRM.Enums;
using AbrPlus.Integration.OpenCRM.Requests;
using AbrPlus.Integration.OpenCRM.Responses;
using AbrPlus.Platform.Client;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Refit;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AbrPlus.Integration.OpenCRM.Client.REST
{
    public class CallStoreApiClient : ICallStoreApiClient, IDisposable
    {
        private readonly ApiClientHandler _handler;
        private bool _disposed;
        protected string Host { get; }
        public virtual string CallStoreId { get; }
        public virtual string CallStoreName { get; }


        public CallStoreApiClient(string callStoreId, string callStoreName, string host, string username, string password, AuthType authType, ILoggerFactory loggerFactory = null)
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

        public CallStoreApiClient(string callStoreId, string callStoreName, string host, BasicAuthorize auth, ILoggerFactory loggerFactory = null)
            : this(callStoreId, callStoreName, host)
        {
            if (auth == null)
                throw new ArgumentNullException(nameof(auth));
            _handler = new ApiClientHandler(auth, loggerFactory ?? NullLoggerFactory.Instance);
        }

        public CallStoreApiClient(string callStoreId, string callStoreName, string host, PublicPasswordFlowAutorize auth, ILoggerFactory loggerFactory = null)
            : this(callStoreId, callStoreName, host)
        {
            if (auth == null)
                throw new ArgumentNullException(nameof(auth));
            _handler = new ApiClientHandler(auth, loggerFactory ?? NullLoggerFactory.Instance);
        }

        public CallStoreApiClient(string callStoreId, string callStoreName, string host, BearerAuthorize auth, ILoggerFactory loggerFactory = null)
            : this(callStoreId, callStoreName, host)
        {

            if (auth == null)
                throw new ArgumentNullException(nameof(auth));
            _handler = new ApiClientHandler(auth, loggerFactory ?? NullLoggerFactory.Instance);
        }

        public CallStoreApiClient(string callStoreId, string callStoreName, string host, ApiKeyAuthorize auth, ILoggerFactory loggerFactory = null)
            : this(callStoreId, callStoreName, host)
        {

            if (auth == null)
                throw new ArgumentNullException(nameof(auth));
            _handler = new ApiClientHandler(auth, loggerFactory ?? NullLoggerFactory.Instance);
        }

        private CallStoreApiClient(string callStoreId, string callStoreName, string host)
        {
            CallStoreId = callStoreId;
            CallStoreName = callStoreName;
            Host = host;
        }
        public async Task<CallCreateResponse> CallCreated([Body] CallCreateRequest callCreateRequest)
        {
            using (var client = CreateClient())
            {
                var api = RestService.For<ICallStoreApiRestClient>(client);
                return await api.CallCreated(callCreateRequest);
            }
        }
        public async Task<CallUpdateResponse> CallUpdated([Body] CallUpdateRequest callUpdateRequest)
        {
            using (var client = CreateClient())
            {
                var api = RestService.For<ICallStoreApiRestClient>(client);
                return await api.CallUpdated(callUpdateRequest);
            }
        }
        public async Task<CallChannelCreateResponse> CallChannelCreated([Body] CallChannelCreateRequest callChannelCreateRequest)
        {
            using (var client = CreateClient())
            {
                var api = RestService.For<ICallStoreApiRestClient>(client);
                return await api.CallChannelCreated(callChannelCreateRequest);
            }
        }
        public async Task<CallChannelUpdateResponse> CallChannelUpdated([Body] CallChannelUpdateRequest callChannelUpdateRequest)
        {
            using (var client = CreateClient())
            {
                var api = RestService.For<ICallStoreApiRestClient>(client);
                return await api.CallChannelUpdated(callChannelUpdateRequest);
            }
        }
        public async Task<MergeCallResponse> MergeCall([Body] MergeCallRequest mergeCallRequest)
        {
            using (var client = CreateClient())
            {
                var api = RestService.For<ICallStoreApiRestClient>(client);
                return await api.MergeCall(mergeCallRequest);
            }
        }
        public async Task<string> GetCallerIdName(string phoneNumber)
        {
            using (var client = CreateClient())
            {
                var api = RestService.For<ICallStoreApiRestClient>(client);
                return await api.GetCallerIdName(phoneNumber);
            }
        }

        public async Task<string> GetProfileUrlFormat()
        {
            using (var client = CreateClient())
            {
                var api = RestService.For<ICallStoreApiRestClient>(client);
                return await api.GetProfileUrlFormat();
            }
        }

        protected virtual HttpClient CreateClient()
        {
            if (_disposed)
                throw new ObjectDisposedException(GetType().Name);

            if (_handler == null)
                return RestService.CreateHttpClient(Host, null);

            var baseAddress = new Uri(Host.TrimEnd('/'));
            return new HttpClient(_handler, disposeHandler: false)
            {
                BaseAddress = baseAddress
            };
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
