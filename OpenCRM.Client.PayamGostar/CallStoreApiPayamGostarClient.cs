using AbrPlus.Integration.OpenCRM.Client.PayamGostar.Mapper;
using AbrPlus.Integration.OpenCRM.Requests;
using AbrPlus.Integration.OpenCRM.Responses;
using Microsoft.Extensions.Logging;
using Payamgostar.Client;
using System.Threading.Tasks;

namespace AbrPlus.Integration.OpenCRM.Client.PayamGostar
{
    public class CallStoreApiPayamGostarClient : ICallStoreApiClient
    {
        public virtual string CallStoreId { get; }
        public virtual string CallStoreName { get; }

        private readonly PayamgostarClient _abrPlusClient;
        public CallStoreApiPayamGostarClient(string callStoreId, string callStoreName, string host, string username, string password, ILoggerFactory loggerFactory)
        {
            CallStoreId = callStoreId;
            CallStoreName = callStoreName;
            _abrPlusClient = new PayamgostarClient(host, new BasicAuthorize { UserName = username, Password = password }, loggerFactory);
        }
        public CallStoreApiPayamGostarClient(string callStoreId, string callStoreName, string host, BasicAuthorize basicAuthorize, ILoggerFactory loggerFactory)
        {
            CallStoreId = callStoreId;
            CallStoreName = callStoreName;
            _abrPlusClient = new PayamgostarClient(host, basicAuthorize, loggerFactory);
        }
        public CallStoreApiPayamGostarClient(string callStoreId, string callStoreName, string host, PasswordFlowAutorize passwordFlowAutorize, ILoggerFactory loggerFactory)
        {
            CallStoreId = callStoreId;
            CallStoreName = callStoreName;
            _abrPlusClient = new PayamgostarClient(host, passwordFlowAutorize, loggerFactory);
        }
        public CallStoreApiPayamGostarClient(string callStoreId, string callStoreName, string host, BearerAuthorize bearerAuthorize, ILoggerFactory loggerFactory)
        {
            CallStoreId = callStoreId;
            CallStoreName = callStoreName;
            _abrPlusClient = new PayamgostarClient(host, bearerAuthorize, loggerFactory);
        }
        public async Task<CallCreateResponse> CallCreated(CallCreateRequest callCreateRequest)
        {
            try
            {

                return (await _abrPlusClient.Telephony.TelephonySystemCallClientApi.TelephonySystemCall_CallCreateAsync(callCreateRequest.ToVm())).ToResponse();

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
                return (await _abrPlusClient.Telephony.TelephonySystemCallClientApi.TelephonySystemCall_CallUpdateAsync(callUpdateRequest.ToVm())).ToResponse();

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
                return (await _abrPlusClient.Telephony.TelephonySystemCallChannelClientApi.TelephonySystemCallChannel_CreateAsync(callChannelCreateRequest.ToVm())).ToResponse();

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
                await _abrPlusClient.Telephony.TelephonySystemCallChannelClientApi.TelephonySystemCallChannel_UpdateAsync(callChannelUpdateRequest.ToVm());
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
                await _abrPlusClient.Telephony.TelephonySystemCallClientApi.TelephonySystemCall_CallMergeAsync(mergeCallRequest.ToVm());
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

        public async Task<string> GetCallerIdName(string phoneNumber)
        {
            try
            {
                return await _abrPlusClient.General.IdentityApiClientApi.IdentityApi_GetCallerIdNameAsync(phoneNumber);
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }

        public async Task<string> GetProfileUrlFormat()
        {
            try
            {
                return await _abrPlusClient.General.IdentityApiClientApi.IdentityApi_GetProfileUrlFormatAsync();
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
    }
}
