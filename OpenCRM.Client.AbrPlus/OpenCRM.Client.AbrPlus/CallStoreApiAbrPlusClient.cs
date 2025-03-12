using AbrPlus.Integration.OpenCRM.Client.AbrPlus.Mapper;
using AbrPlus.Integration.OpenCRM.Requests;
using AbrPlus.Integration.OpenCRM.Responses;
using AbrPlus.Platform.Client;
using System.Threading.Tasks;

namespace AbrPlus.Integration.OpenCRM.Client.AbrPlus
{
    public class CallStoreApiAbrPlusClient : ICallStoreApiClient
    {
        public virtual string CallStoreId { get; }
        private readonly AbrPlusClient _abrPlusClient;
        public CallStoreApiAbrPlusClient(string callStoreId, string baseUrl, PasswordFlowAutorize passwordFlow)
        {
            CallStoreId = callStoreId;
            _abrPlusClient = new AbrPlusClient(baseUrl, passwordFlow);
        }
        public async Task<CallCreateResponse> CallCreated(CallCreateRequest callCreateRequest)
        {

            return (await _abrPlusClient.CallClient.ExternalTelephonySystemClientApi.CreateCallAsync(callCreateRequest.ToVm())).ToResponse();

        }
        public async Task<CallUpdateResponse> CallUpdated(CallUpdateRequest callUpdateRequest)
        {
            return (await _abrPlusClient.CallClient.ExternalTelephonySystemClientApi.UpdateCallAsync(callUpdateRequest.ToVm())).ToResponse();

        }
        public async Task<CallChannelCreateResponse> CallChannelCreated(CallChannelCreateRequest callChannelCreateRequest)
        {

            return (await _abrPlusClient.CallClient.ExternalTelephonySystemClientApi.CreateChannelAsync(callChannelCreateRequest.ToVm())).ToResponse();

        }
        public async Task<CallChannelUpdateResponse> CallChannelUpdated(CallChannelUpdateRequest callChannelUpdateRequest)
        {
            await _abrPlusClient.CallClient.ExternalTelephonySystemClientApi.UpdateChannelAsync(callChannelUpdateRequest.ToVm());
            return new CallChannelUpdateResponse()
            {
                CallChannelId = callChannelUpdateRequest.ChannelId,
            };
        }
        public async Task<MergeCallResponse> MergeCall(MergeCallRequest mergeCallRequest)
        {
            await _abrPlusClient.CallClient.ExternalTelephonySystemClientApi.MergeCallAsync(mergeCallRequest.ToVm());
            return new MergeCallResponse()
            {
                Merged = true
            };
        }

    }
}
