using AbrPlus.Integration.OpenCRM.Client.AbrPlus.Mapper;
using AbrPlus.Integration.OpenCRM.Requests;
using AbrPlus.Integration.OpenCRM.Responses;
using AbrPlus.Platform.Client;
using AbrPlus.Platform.Client.Call;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace AbrPlus.Integration.OpenCRM.Client.AbrPlus
{
    public class CallStoreApiAbrPlusClient : ICallStoreApiClient
    {
        public virtual string CallStoreId { get; }
        private readonly AbrPlusClient _abrPlusClient;
        public CallStoreApiAbrPlusClient(string callStoreId, string baseUrl, PasswordFlowAutorize passwordFlow, ILoggerFactory loggerFactory)
        {
            CallStoreId = callStoreId;
            _abrPlusClient = new AbrPlusClient(baseUrl, passwordFlow, loggerFactory);
        }
        public async Task<CallCreateResponse> CallCreated(CallCreateRequest callCreateRequest)
        {
            try
            {

                return (await _abrPlusClient.Call.ExternalTelephonySystemClientApi.CreateCallAsync(callCreateRequest.ToVm())).ToResponse();

            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
        public async Task<CallUpdateResponse> CallUpdated(CallUpdateRequest callUpdateRequest)
        {
            try
            {
                return (await _abrPlusClient.Call.ExternalTelephonySystemClientApi.UpdateCallAsync(callUpdateRequest.ToVm())).ToResponse();

            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
        public async Task<CallChannelCreateResponse> CallChannelCreated(CallChannelCreateRequest callChannelCreateRequest)
        {

            try
            {
                return (await _abrPlusClient.Call.ExternalTelephonySystemClientApi.CreateChannelAsync(callChannelCreateRequest.ToVm())).ToResponse();

            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
        public async Task<CallChannelUpdateResponse> CallChannelUpdated(CallChannelUpdateRequest callChannelUpdateRequest)
        {
            try
            {
                await _abrPlusClient.Call.ExternalTelephonySystemClientApi.UpdateChannelAsync(callChannelUpdateRequest.ToVm());
                return new CallChannelUpdateResponse()
                {
                    CallChannelId = callChannelUpdateRequest.ChannelId,
                };
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
        public async Task<MergeCallResponse> MergeCall(MergeCallRequest mergeCallRequest)
        {
            try
            {
                await _abrPlusClient.Call.ExternalTelephonySystemClientApi.MergeCallAsync(mergeCallRequest.ToVm());
                return new MergeCallResponse()
                {
                    Merged = true
                };
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }

    }
}
