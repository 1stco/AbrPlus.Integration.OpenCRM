using AbrPlus.Integration.Telephony.Enums;
using System;

namespace AbrPlus.Integration.OpenCRM.Requests
{
    public class CallChannelUpdateRequest
    {
        public string TsKey { get; set; }
        public bool IsLive { get; set; }
        public string CallId { get; set; }
        public string ChannelId { get; set; }
        public string CallNumber { get; set; }
        public CallType CallType { get; set; }
        public string IdentityId { get; set; }
        public string PeerName { get; set; }
        public PeerType PeerType { get; set; }
        public ChannelState ChannelState { get; set; }
        public ChannelResponse ChannelResponse { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ConnectDate { get; set; }
        public DateTime? HangupDate { get; set; }
        public string RecordedFileName { get; set; }
        public string ToChangePeerName { get; set; } = "";
        public PeerType? ToChangePeerType { get; set; } = null;
        public string RefCallId { get; set; }
        public string RefChannelId { get; set; }
    }
}
