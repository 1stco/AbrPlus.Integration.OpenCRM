//using AbrPlus.Platform.Client;

using AbrPlus.Integration.OpenCRM.Requests;
using AbrPlus.Integration.OpenCRM.Responses;
using AbrPlus.Platform.Client;
using SeptaKit.Extensions;

namespace AbrPlus.Integration.OpenCRM.Client.AbrPlus.Mapper
{
    public static class CallMapper
    {
        public static CreateCallRequestVm ToVm(this CallCreateRequest request)
        {
            return new CreateCallRequestVm()
            {
                InitChannelPeerName = request.SourceInitCallChannelPeerName,
                InitChannelPeerType = (PeerType)request.SourceInitCallChannelPeerType,
                InitChannelSourceId = request.SourceInitCallChannelId,
                IsLive = request.IsLive,
                PhoneCallType = (CallType)request.CallType,
                PhoneNumber = request.Number,
                SourceId = request.SourceCallId,
                StartDate = request.Date,
                TsKey = request.TsKey,
            };
        }

        public static CallCreateResponse ToResponse(this CreateCallResponseVm vm)
        {
            return new CallCreateResponse()
            {
                CallId = vm.CallId.ToString(),
                IdentityId = vm.IdentityId?.ToString(),
                IdentityName = vm.IdentityNickName,
                InitCallChannelId = vm.InitChannelId.ToString(),
            };
        }

        public static UpdateCallRequestVm ToVm(this CallUpdateRequest request)
        {
            var callId = request.CallId.ToLong();
            if (callId == null)
            {
                throw new System.Exception("callId is invalid");
            }
            return new UpdateCallRequestVm()
            {
                TsKey = request.TsKey,
                CallId = callId.Value,
                PhoneNumber = request.Number,
                CallTypeIndex = (CallType)request.CallType,
                IdentityId = request.IdentityId?.ToGuid(),
                IsLive = request.IsLive,
                EndDate = request.Date,
            };
        }

        public static CallUpdateResponse ToResponse(this UpdateCallResponseVm vm)
        {
            return new CallUpdateResponse()
            {
                IdentityId = vm.IdentityId?.ToString(),
                IdentityName = vm.IdentityNickName,
            };
        }

        public static CallChannelCreateRequestVm ToVm(this CallChannelCreateRequest request)
        {
            var callId = request.CallId.ToLong();
            if (callId == null)
            {
                throw new System.Exception("callId is invalid");
            }

            return new CallChannelCreateRequestVm()
            {
                CallId = callId.Value,
                ChannelPeerName = request.PeerName,
                ChannelPeerTypeIndex = (PeerType)request.PeerType,
                ChannelSourceId = request.SourceCallChannelId,
                ChannelStatus = (ChannelState)request.ChannelState,
                CreateDate = request.CreateDate,
                IsLive = request.IsLive,
                TsKey = request.TsKey,
            };
        }

        public static CallChannelCreateResponse ToResponse(this CallChannelCreateResponseVm vm)
        {
            return new CallChannelCreateResponse()
            {
                CallChannelId = vm.CallChannelId.ToString(),
            };
        }

        public static CallChannelUpdateRequestVm ToVm(this CallChannelUpdateRequest request)
        {
            var callChannelId = request.ChannelId.ToLong();
            if (callChannelId == null)
            {
                throw new System.Exception("callId is invalid");
            }
            return new CallChannelUpdateRequestVm()
            {
                CallChannelId = callChannelId.Value,
                ChannelStatus = (ChannelState)request.ChannelState,
                ChannelResponse = (ChannelResponse)request.ChannelResponse,
                ConnectDate = request.ConnectDate,
                HangupDate = request.HangupDate,
                IsLive = request.IsLive,
                RecordedFileName = request.RecordedFileName,
                ToChangePeerName = request.ToChangePeerName,
                ToChangePeerTypeIndex = (PeerType)request.ToChangePeerType,
                TsKey = request.TsKey,
            };
        }

        public static MergeCallRequestVm ToVm(this MergeCallRequest request)
        {
            return new MergeCallRequestVm()
            {
                DestinationCallId = request.DestCallId,
                SourceCallId = request.SourceCallId,
                TsKey = request.TsKey,
            };
        }
    }
}
