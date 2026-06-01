using AbrPlus.Integration.OpenCRM.Enums;
using AbrPlus.Integration.OpenCRM.Requests;
using AbrPlus.Integration.OpenCRM.Responses;
using System.Threading;
using System.Threading.Tasks;

namespace AbrPlus.Integration.OpenCRM.Client.JsonRPC
{
    public class LookupSourceJsonRPCClient : CallStoreJsonRPCClient, ILookupSourceApiClient
    {
        public LookupSourceJsonRPCClient(string callStoreId, string callStoreName, string host, string username, string password, AuthType authType)
            : base(callStoreId, callStoreName, host, username, password, authType)
        {
        }

        public Task<CreateInvoiceResponse> CreateInvoice(CreateSalesInvoiceRequest createSalesInvoiceRequest)
        {
            return SendAsync<CreateSalesInvoiceRequest, CreateInvoiceResponse>(
                "invoice",
                "salesInvoice",
                createSalesInvoiceRequest,
                CancellationToken.None);
        }

        public Task<BillableObjectTypePropsResponse> GetBillableObjectTypeProps(
            BillableObjectTypePropsRequest billableObjectTypePropsRequest)
        {
            return SendAsync<BillableObjectTypePropsRequest, BillableObjectTypePropsResponse>(
                "financial",
                "billableObjectTypeProps",
                billableObjectTypePropsRequest,
                CancellationToken.None);
        }

        public Task<BillableObjectTypesResponse> GetBillableObjectTypes()
        {
            return SendAsync<object, BillableObjectTypesResponse>(
                "financial",
                "billableObjectTypes",
                null,
                CancellationToken.None);
        }

        public Task<CardtableResponse> GetCardtable(CardtableRequest cardtableRequest)
        {
            return SendAsync<CardtableRequest, CardtableResponse>(
                "user",
                "cardtable",
                cardtableRequest,
                CancellationToken.None);
        }

        public Task<IdentityBalanceResponse> GetIdentityBalance(CustomerRequest customerRequest)
        {
            return SendAsync<CustomerRequest, IdentityBalanceResponse>(
                "identity",
                "balance",
                customerRequest,
                CancellationToken.None);
        }

        public Task<IdentityResponse> GetIdentityByCustomerInfo(CustomerRequest customerRequest)
        {
            return SendAsync<CustomerRequest, IdentityResponse>(
                "identity",
                "findByCustomerInfo",
                customerRequest,
                CancellationToken.None);
        }

        public Task<IdentityResponse> GetIdentityByCustomerNumber(
            IdentityByCustomerNumberRequest identityByCustomerNumberRequest)
        {
            return SendAsync<IdentityByCustomerNumberRequest, IdentityResponse>(
                "identity",
                "findByCustomerNumber",
                identityByCustomerNumberRequest,
                CancellationToken.None);
        }

        public Task<IdentityResponse> GetIdentityByPhoneNumber(
            IdentityByPhoneNumberRequest identityByPhoneNumberRequest)
        {
            return SendAsync<IdentityByPhoneNumberRequest, IdentityResponse>(
                "identity",
                "findByPhoneNumber",
                identityByPhoneNumberRequest,
                CancellationToken.None);
        }

        public Task<MoneyAccountsResponse> GetMoneyAccounts()
        {
            return SendAsync<object, MoneyAccountsResponse>(
                "financial",
                "moneyAccounts",
                null,
                CancellationToken.None);
        }

        public Task<PaymentResponse> GetPaymentInfo(PaymentInfoRequest paymentInfoRequest)
        {
            return SendAsync<PaymentInfoRequest, PaymentResponse>(
                "financial",
                "paymentInfo",
                paymentInfoRequest,
                CancellationToken.None);
        }

        public Task<UserExtensionResponse> GetUserDefaultExtension(
            UserExtensionRequest userExtensionRequest)
        {
            return SendAsync<UserExtensionRequest, UserExtensionResponse>(
                "user",
                "defaultExtension",
                userExtensionRequest,
                CancellationToken.None);
        }

        public Task<UserTelephonySystemResponse> GetUserExtensions(
            UserExtensionsRequest userExtenstionsRequest)
        {
            return SendAsync<UserExtensionsRequest, UserTelephonySystemResponse>(
                "user",
                "userExtensions",
                userExtenstionsRequest,
                CancellationToken.None);
        }

        public Task<UserResponse> GetUserInfoByIdentityId(
            UserInfoByIdentityRequest userInfoByIdentityRequest)
        {
            return SendAsync<UserInfoByIdentityRequest, UserResponse>(
                "user",
                "userInfoByIdentityId",
                userInfoByIdentityRequest,
                CancellationToken.None);
        }

        public Task<UserExtensionResponse> GetUserManagerExtension(
            UserManagerByExtensionRequest userManagerByExtensionRequest)
        {
            return SendAsync<UserManagerByExtensionRequest, UserExtensionResponse>(
                "user",
                "userManagerExtension",
                userManagerByExtensionRequest,
                CancellationToken.None);
        }

        public Task<IdentityContractStatusResponse> GetIdentityContractStatus(
            IdentityContractStatusRequest identityHasValidContractRequest)
        {
            return SendAsync<IdentityContractStatusRequest, IdentityContractStatusResponse>(
                "contract",
                "identityContractStatus",
                identityHasValidContractRequest,
                CancellationToken.None);
        }

        public Task<SendPaymentLinkToUserResponse> SendPaymentLinkToUser(
            SendPaymentLinkToUserRequest sendPaymentLinkToUserRequest)
        {
            return SendAsync<SendPaymentLinkToUserRequest, SendPaymentLinkToUserResponse>(
                "financial",
                "sendPaymentLinkToUser",
                sendPaymentLinkToUserRequest,
                CancellationToken.None);
        }

        public Task<CrmObjectUrlResponse> GetCrmObjectUrl(
            CrmObjectUrlRequest crmObjectUrlRequest)
        {
            return SendAsync<CrmObjectUrlRequest, CrmObjectUrlResponse>(
                "general",
                "findCrmObjectUrl",
                crmObjectUrlRequest,
                CancellationToken.None);
        }

        public Task<SubmitQueueOperatorVotingResponse> SubmitQueueOperatorVoting(
            SubmitQueueOperatorVotingRequest submitQueueOperatorVotingRequest)
        {
            return SendAsync<SubmitQueueOperatorVotingRequest, SubmitQueueOperatorVotingResponse>(
                "voting",
                "queueOperatorVoting",
                submitQueueOperatorVotingRequest,
                CancellationToken.None);
        }

        public Task<SubmitVotingResponse> SubmitVoting(SubmitVotingRequest submitVotingRequest)
        {
            return SendAsync<SubmitVotingRequest, SubmitVotingResponse>(
                "voting",
                "voting",
                submitVotingRequest,
                CancellationToken.None);
        }
    }
}