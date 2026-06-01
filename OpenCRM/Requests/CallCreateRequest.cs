using AbrPlus.Integration.Telephony.Enums;
using System;

namespace AbrPlus.Integration.OpenCRM.Requests
{
    public class CallCreateRequest
    {
        public string TsKey { get; set; }
        public bool IsLive { get; set; }
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public CallType CallType { get; set; }
        public CallResult CallResult { get; set; }
        public string InitCallChannelPeerName { get; set; }
        public PeerType InitCallChannelPeerType { get; set; }
        public string RefCallId { get; set; }
        public string RefInitCallChannelId { get; set; }
    }
}