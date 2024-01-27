﻿using AbrPlus.Integration.OpenCRM.Responses;

namespace AbrPlus.Integration.OpenCRM.Requests
{
    public class SendPaymentLinkToUserRequest
    {
        public PaymentResponse PaymentInfo { get; set; }
        public string MobileNumber { get; set; }
        public string MoneyAccountUserKey { get; set; }
        public string ResultMessage { get; set; }
    }
}
