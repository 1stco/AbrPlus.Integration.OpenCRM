﻿using AbrPlus.Integration.Telephony.Enums;
using System;

namespace AbrPlus.Integration.OpenCRM.Requests
{
    public class CallUpdateRequest
    {
        public string TsKey { get; set; }
        public string CallId { get; set; }
        public bool IsLive { get; set; }
        public string Number { get; set; }
        public DateTime? Date { get; set; }
        public CallType CallType { get; set; }
        public CallResult CallResult { get; set; }
        public string IdentityId { get; set; }
    }
}
