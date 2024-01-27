using AbrPlus.Integration.OpenCRM.Requests;
using AbrPlus.Integration.OpenCRM.Responses;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace AbrPlus.Integration.OpenCRM
{
    public interface ILookupSourceApi : ICallStoreApi
    {
        Task<IdentityResponse> GetIdentityByCustomerInfo(CustomerRequest customerRequest);
        Task<IdentityResponse> GetIdentityByPhoneNumber(IdentityByPhoneNumberRequest identityByPhoneNumberRequest);
        Task<IdentityResponse> GetIdentityByCustomerNumber(IdentityByCustomerNumberRequest identityByCustomerNumberRequest);

        Task<IdentityContractStatusResponse> GetIdentityContractStatus(IdentityContractStatusRequest identityHasValidContractRequest);

        Task<UserResponse> GetUserInfoByIdentityId(UserInfoByIdentityRequest userInfoByIdentityRequest);
        Task<UserTelephonySystemResponse> GetUserExtensions(UserExtensionsRequest userExtenstionsRequest);
        Task<UserExtensionResponse> GetUserDefaultExtension(UserExtensionRequest userExtensionRequest);
        Task<UserExtensionResponse> GetUserManagerExtension(UserManagerByExtensionRequest userManagerByExtensionRequest);
        Task<IdentityBalanceResponse> GetIdentityBalance(CustomerRequest customerRequest);

        Task<CardtableResponse> GetCardtable(CardtableRequest cardtableRequest);

        Task<BillableObjectTypesResponse> GetBillableObjectTypes();
        Task<MoneyAccountsResponse> GetMoneyAccounts();

        Task<CreateInvoiceResponse> CreateInvoice(CreateSalesInvoiceRequest createSalesInvoiceRequest);
        Task<BillableObjectTypePropsResponse> GetBillableObjectTypeProps(BillableObjectTypePropsRequest billableObjectTypePropsRequest);
        Task<PaymentResponse> GetPaymentInfo(PaymentInfoRequest paymentInfoRequest);
        Task<SendPaymentLinkToUserResponse> SendPaymentLinkToUser(SendPaymentLinkToUserRequest sendPaymentLinkToUserRequest);
        Task<CrmObjectUrlResponse> GetCrmObjectUrl(CrmObjectUrlRequest crmObjectUrlRequest);

        Task<SubmitQueueOperatorVotingResponse> SubmitQueueOperatorVoting(SubmitQueueOperatorVotingRequest submitQueueOperatorVotingRequest);
        Task<SubmitVotingResponse> SubmitVoting(SubmitVotingRequest submitVotingRequest);
    }
}