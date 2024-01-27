using AbrPlus.Integration.OpenCRM.Requests;
using AbrPlus.Integration.OpenCRM.Responses;
using Refit;
using System;
using System.Threading.Tasks;

namespace AbrPlus.Integration.OpenCRM.Client.REST
{
    public interface ILookupSourceApiRestClient : ICallStoreApiRestClient
    {
        [Get("/financial/moneyAccounts")]
        Task<MoneyAccountsResponse> GetMoneyAccounts();
        [Get("/financial/billableObjectTypes")]
        Task<BillableObjectTypesResponse> GetBillableObjectTypes();
        [Get("/financial/billableObjectTypeProps")]
        Task<BillableObjectTypePropsResponse> GetBillableObjectTypeProps([Query] BillableObjectTypePropsRequest billableObjectTypePropsRequest);
        [Get("/financial/paymentInfo")]
        Task<PaymentResponse> GetPaymentInfo([Query] PaymentInfoRequest paymentInfoRequest);
        [Post("/financial/sendPaymentLinkToUser")]
        Task<SendPaymentLinkToUserResponse> SendPaymentLinkToUser([Body] SendPaymentLinkToUserRequest sendPaymentLinkToUserRequest);


        [Get("/general/findCrmObjectUrl")]
        Task<CrmObjectUrlResponse> GetCrmObjectUrl([Query] CrmObjectUrlRequest crmObjectUrlRequest);


        [Get("/user/cardtable")]
        Task<CardtableResponse> GetCardtable([Query] CardtableRequest cardtableRequest);
        [Get("/user/defaultExtension")]
        Task<UserExtensionResponse> GetUserDefaultExtension([Query] UserExtensionRequest userExtensionRequest);
        [Get("/user/userInfoByIdentityId")]
        Task<UserResponse> GetUserInfoByIdentityId([Query] UserInfoByIdentityRequest userInfoByIdentityRequest);
        [Get("/user/userExtensions")]
        Task<UserTelephonySystemResponse> GetUserExtensions([Query] UserExtensionsRequest userExtenstionsRequest);
        [Get("/user/userManagerExtension")]
        Task<UserExtensionResponse> GetUserManagerExtension([Query] UserManagerByExtensionRequest userManagerByExtensionRequest);


        [Get("/identity/findByCustomerInfo")]
        Task<IdentityResponse> GetIdentityByCustomerInfo([Query] CustomerRequest customerRequest);
        [Get("/identity/findByPhoneNumber")]
        Task<IdentityResponse> GetIdentityByPhoneNumber([Query] IdentityByPhoneNumberRequest identityByPhoneNumberRequest);
        [Get("/identity/findByCustomerNumber")]
        Task<IdentityResponse> GetIdentityByCustomerNumber([Query] IdentityByCustomerNumberRequest identityByCustomerNumberRequest);
        [Get("/identity/balance")]
        Task<IdentityBalanceResponse> GetIdentityBalance([Query] CustomerRequest customerRequest);


        [Post("/invoice/salesInvoice")]
        Task<CreateInvoiceResponse> CreateInvoice([Body] CreateSalesInvoiceRequest createSalesInvoiceRequest);



        [Get("/contract/identityContractStatus")]
        Task<IdentityContractStatusResponse> GetIdentityContractStatus([Query] IdentityContractStatusRequest identityHasValidContractRequest);



        [Post("/voting/queueOperatorVoting")]
        Task<SubmitQueueOperatorVotingResponse> SubmitQueueOperatorVoting([Body] SubmitQueueOperatorVotingRequest submitQueueOperatorVotingRequest);
        [Post("/voting/voting")]
        Task<SubmitVotingResponse> SubmitVoting([Body] SubmitVotingRequest submitVotingRequest);
    }
}