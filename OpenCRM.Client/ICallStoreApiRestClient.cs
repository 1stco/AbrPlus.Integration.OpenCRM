using AbrPlus.Integration.OpenCRM.Requests;
using AbrPlus.Integration.OpenCRM.Responses;
using Refit;
using System.Threading.Tasks;

namespace AbrPlus.Integration.OpenCRM.Client.Rest
{
    public interface ICallStoreApiRestClient
    {
        [Post("/call/CallCreated")]
        Task<CallCreateResponse> CallCreated([Body] CallCreateRequest callCreateRequest);

        [Post("/call/CallUpdated")]
        Task<CallUpdateResponse> CallUpdated([Body] CallUpdateRequest callUpdateRequest);

        [Post("/call/CallChannelCreated")]
        Task<CallChannelCreateResponse> CallChannelCreated([Body] CallChannelCreateRequest callChannelCreateRequest);

        [Post("/call/CallChannelUpdated")]
        Task<CallChannelUpdateResponse> CallChannelUpdated([Body] CallChannelUpdateRequest callChannelUpdateRequest);

        [Post("/call/MergeCall")]
        Task<MergeCallResponse> MergeCall([Body] MergeCallRequest mergeCallRequest);
    }
}
