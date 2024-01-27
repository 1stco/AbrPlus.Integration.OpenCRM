using AbrPlus.Integration.OpenCRM.Requests;
using AbrPlus.Integration.OpenCRM.Responses;
using System.Threading.Tasks;

namespace AbrPlus.Integration.OpenCRM
{
    public interface ICallStoreApi
    {
        Task<CallCreateResponse> CallCreated(CallCreateRequest callCreateRequest);
        Task<CallUpdateResponse> CallUpdated(CallUpdateRequest callUpdateRequest);
        Task<CallChannelCreateResponse> CallChannelCreated(CallChannelCreateRequest callChannelCreateRequest);
        Task<CallChannelUpdateResponse> CallChannelUpdated(CallChannelUpdateRequest callChannelUpdateRequest);
        Task<MergeCallResponse> MergeCall(MergeCallRequest mergeCallRequest);
    }
}
