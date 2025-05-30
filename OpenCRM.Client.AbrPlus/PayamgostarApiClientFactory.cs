﻿using PgContractService;
using PgCrmObjectService;
using PgCrmObjectType;
using PgEPayService;
using PgIdentityService;
using PgInvoiceService;
using PgMoneyAccountService;
using PgPaymentService;
using PgUserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace AbrPlus.Integration.OpenCRM.Client.AbrPlus
{
    class PayamgostarApiClientFactory<TContract>
    {
        public TContract Create(string endPointAddress)
        {
            string uri = $"{endPointAddress}{ServicePathLocation}";
            return CreateHttpClientService(uri);
        }
        public TContract CreateHttpClientService(string address)
        {
            var toAdd = GetChannelFactory(address);
            return toAdd.CreateChannel();
        }

        private ChannelFactory<TContract> GetChannelFactory(string address)
        {
            Uri serviceUri = new Uri(address);
            EndpointAddress serviceEP = new EndpointAddress(serviceUri);
            BasicHttpBinding basicHttp = new BasicHttpBinding(BasicHttpSecurityMode.None);

            if (serviceUri.Scheme == "https")
            {
                basicHttp.Security.Mode = BasicHttpSecurityMode.Transport;
                basicHttp.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
            }

            basicHttp.MaxReceivedMessageSize = int.MaxValue;
            basicHttp.MaxBufferPoolSize = int.MaxValue;
            basicHttp.MaxBufferSize = int.MaxValue;

            basicHttp.ReaderQuotas.MaxStringContentLength = int.MaxValue;
            basicHttp.ReaderQuotas.MaxDepth = int.MaxValue;
            basicHttp.ReaderQuotas.MaxArrayLength = int.MaxValue;
            basicHttp.ReaderQuotas.MaxBytesPerRead = 4096;
            basicHttp.ReaderQuotas.MaxNameTableCharCount = int.MaxValue;


            basicHttp.ReceiveTimeout = TimeSpan.FromSeconds(20);

            return new ChannelFactory<TContract>(basicHttp, serviceEP);
        }

        private string ServicePathLocation
        {
            get
            {
                return new Dictionary<Type, string>
                {
                    { typeof(IIdentityChannel), "/services/api/IIdentity.svc"},
                    { typeof(IUser), "/services/api/IUser.svc"},
                    { typeof(IUserChannel), "/services/api/IUser.svc"},
                    { typeof(IContractChannel), "/services/api/IContract.svc"},
                    { typeof(ICrmObjectChannel), "/services/api/ICrmObject.svc"},
                    { typeof(ICrmObjectTypeChannel), "/services/api/ICrmObjectType.svc"},
                    { typeof(IEpayChannel), "/services/api/IEpay.svc"},
                    { typeof(IInvoiceChannel), "/services/api/IInvoice.svc"},
                    { typeof(IMoneyAccountChannel), "/services/api/IMoneyAccount.svc"},
                    { typeof(IPaymentChannel), "/services/api/IPayment.svc"},
                }.First(x => x.Key == typeof(TContract)).Value;
            }
        }
    }
}
