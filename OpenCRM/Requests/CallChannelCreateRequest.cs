using AbrPlus.Integration.Telephony.Enums;
using System;

namespace AbrPlus.Integration.OpenCRM.Requests
{
    public class CallChannelCreateRequest
    {
        public string TsKey { get; set; }
        public string CallId { get; set; }
        public bool IsLive { get; set; }
        public string PeerName { get; set; }
        public PeerType PeerType { get; set; }
        public string SourceCallChannelId { get; set; }
        public ChannelState ChannelState { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
