using AbrPlus.Integration.OpenCRM.Enums;
using AbrPlus.Integration.OpenCRM.Requests;
using AbrPlus.Integration.OpenCRM.Responses;
using Refit;
using System.Threading.Tasks;

namespace AbrPlus.Integration.OpenCRM.Client.Rest
{
    public class LookupSourceApiRestClient : CallStoreApiRestClient, ILookupSourceApiClient, ILookupSourceApiRestClient
    {

        public LookupSourceApiRestClient(string lookupSourceId, string host, string username, string password, AuthType authType)
            : base(lookupSourceId, host, username, password, authType)
        {
        }

        public async Task<CreateInvoiceResponse> CreateInvoice(CreateSalesInvoiceRequest createSalesInvoiceRequest)
        {
            using (var client = CreateClient())
            {
                var api = RestService.For<ILookupSourceApiRestClient>(client);
                return await api.CreateInvoice(createSalesInvoiceRequest);
            }
        }

        public async Task<BillableObjectTypePropsResponse> GetBillableObjectTypeProps(BillableObjectTypePropsRequest billableObjectTypePropsRequest)
        {
            using (var client = CreateClient())
            {
                var api = RestService.For<ILookupSourceApiRestClient>(client);
                return await api.GetBillableObjectTypeProps(billableObjectTypePropsRequest);
            }
        }

        public async Task<BillableObjectTypesResponse> GetBillableObjectTypes()
        {
            using (var client = CreateClient())
            {
                var api = RestService.For<ILookupSourceApiRestClient>(client);
                return await api.GetBillableObjectTypes();
            }
        }

        public async Task<CardtableResponse> GetCardtable(CardtableRequest cardtableRequest)
        {
            using (var client = CreateClient())
            {
                var api = RestService.For<ILookupSourceApiRestClient>(client);
                return await api.GetCardtable(cardtableRequest);
            }
        }

        public async Task<IdentityBalanceResponse> GetIdentityBalance(CustomerRequest customerRequest)
        {
            using (var client = CreateClient())
            {
                var api = RestService.For<ILookupSourceApiRestClient>(client);
                return await api.GetIdentityBalance(customerRequest);
            }
        }

        public async Task<IdentityResponse> GetIdentityByCustomerInfo(CustomerRequest customerRequest)
        {
            using (var client = CreateClient())
            {
                var api = RestService.For<ILookupSourceApiRestClient>(client);
                return await api.GetIdentityByCustomerInfo(customerRequest);
            }
        }

        public async Task<IdentityResponse> GetIdentityByCustomerNumber(IdentityByCustomerNumberRequest identityByCustomerNumberRequest)
        {

            using (var client = CreateClient())
            {
                var api = RestService.For<ILookupSourceApiRestClient>(client);
                return await api.GetIdentityByCustomerNumber(identityByCustomerNumberRequest);
            }
        }

        public async Task<IdentityResponse> GetIdentityByPhoneNumber(IdentityByPhoneNumberRequest identityByPhoneNumberRequest)
        {
            using (var client = CreateClient())
            {
                var api = RestService.For<ILookupSourceApiRestClient>(client);
                return await api.GetIdentityByPhoneNumber(identityByPhoneNumberRequest);
            }
        }

        public async Task<MoneyAccountsResponse> GetMoneyAccounts()
        {
            using (var client = CreateClient())
            {
                var api = RestService.For<ILookupSourceApiRestClient>(client);
                return await api.GetMoneyAccounts();
            }
        }

        public async Task<PaymentResponse> GetPaymentInfo(PaymentInfoRequest paymentInfoRequest)
        {
            using (var client = CreateClient())
            {
                var api = RestService.For<ILookupSourceApiRestClient>(client);
                return await api.GetPaymentInfo(paymentInfoRequest);
            }
        }

        public async Task<UserExtensionResponse> GetUserDefaultExtension(UserExtensionRequest userExtensionRequest)
        {
            using (var client = CreateClient())
            {
                var api = RestService.For<ILookupSourceApiRestClient>(client);
                return await api.GetUserDefaultExtension(userExtensionRequest);
            }
        }

        public async Task<UserTelephonySystemResponse> GetUserExtensions(UserExtensionsRequest userExtenstionsRequest)
        {
            using (var client = CreateClient())
            {
                var api = RestService.For<ILookupSourceApiRestClient>(client);
                return await api.GetUserExtensions(userExtenstionsRequest);
            }
        }

        public async Task<UserResponse> GetUserInfoByIdentityId(UserInfoByIdentityRequest userInfoByIdentityRequest)
        {
            using (var client = CreateClient())
            {
                var api = RestService.For<ILookupSourceApiRestClient>(client);
                return await api.GetUserInfoByIdentityId(userInfoByIdentityRequest);
            }
        }

        public async Task<UserExtensionResponse> GetUserManagerExtension(UserManagerByExtensionRequest userManagerByExtensionRequest)
        {
            using (var client = CreateClient())
            {
                var api = RestService.For<ILookupSourceApiRestClient>(client);
                return await api.GetUserManagerExtension(userManagerByExtensionRequest);
            }
        }

        public async Task<IdentityContractStatusResponse> GetIdentityContractStatus(IdentityContractStatusRequest identityHasValidContractRequest)
        {
            using (var client = CreateClient())
            {
                var api = RestService.For<ILookupSourceApiRestClient>(client);
                return await api.GetIdentityContractStatus(identityHasValidContractRequest);
            }
        }

        public async Task<SendPaymentLinkToUserResponse> SendPaymentLinkToUser(SendPaymentLinkToUserRequest sendPaymentLinkToUserRequest)
        {
            using (var client = CreateClient())
            {
                var api = RestService.For<ILookupSourceApiRestClient>(client);
                return await api.SendPaymentLinkToUser(sendPaymentLinkToUserRequest);
            }
        }

        public async Task<CrmObjectUrlResponse> GetCrmObjectUrl(CrmObjectUrlRequest crmObjectUrlRequest)
        {
            using (var client = CreateClient())
            {
                var api = RestService.For<ILookupSourceApiRestClient>(client);
                return await api.GetCrmObjectUrl(crmObjectUrlRequest);
            }
        }

        public async Task<SubmitQueueOperatorVotingResponse> SubmitQueueOperatorVoting(SubmitQueueOperatorVotingRequest submitQueueOperatorVotingRequest)
        {
            using (var client = CreateClient())
            {
                var api = RestService.For<ILookupSourceApiRestClient>(client);
                return await api.SubmitQueueOperatorVoting(submitQueueOperatorVotingRequest);
            }
        }

        public async Task<SubmitVotingResponse> SubmitVoting(SubmitVotingRequest submitVotingRequest)
        {
            using (var client = CreateClient())
            {
                var api = RestService.For<ILookupSourceApiRestClient>(client);
                return await api.SubmitVoting(submitVotingRequest);
            }
        }
    }
}