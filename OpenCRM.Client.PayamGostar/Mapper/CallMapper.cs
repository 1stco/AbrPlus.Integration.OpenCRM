using AbrPlus.Integration.OpenCRM.Requests;
using AbrPlus.Integration.OpenCRM.Responses;
using Payamgostar.Client.Telephony;
using SeptaKit.Extensions;

namespace AbrPlus.Integration.OpenCRM.Client.PayamGostar.Mapper
{
    public static class CallMapper
    {
        public static CallCreateModel ToVm(this CallCreateRequest request)
        {
            return new CallCreateModel()
            {
                InitChannelPeerName = request.InitCallChannelPeerName,
                InitChannelPeerTypeIndex = (Gp_TelephonySystemPeerType)request.InitCallChannelPeerType,
                InitChannelSourceId = request.RefInitCallChannelId,
                IsLive = request.IsLive,
                CallTypeIndex = (Gp_PhoneCallType)request.CallType,
                PhoneNumber = request.Number,
                SourceId = request.RefCallId,
                StartDate = request.Date,
                TsKey = request.TsKey,
            };
        }

        public static CallCreateResponse ToResponse(this CallCreateResult vm)
        {
            return new CallCreateResponse()
            {
                CallId = vm.CallId.ToString(),
                IdentityId = vm.IdentityId?.ToString(),
                IdentityName = vm.IdentityNickName,
                InitCallChannelId = vm.InitChannelId.ToString(),
            };
        }

        public static CallUpdateModel ToVm(this CallUpdateRequest request)
        {
            var callId = request.CallId.ToLong();
            if (callId == null)
            {
                throw new System.Exception("callId is invalid");
            }
            return new CallUpdateModel()
            {
                //TsKey = request.TsKey,
                CallId = callId.Value,
                PhoneNumber = request.Number,
                CallTypeIndex = (Gp_PhoneCallType)request.CallType,
                IdentityId = request.IdentityId?.ToGuid(),
                IsLive = request.IsLive,
                EndDate = request.Date,
            };
        }

        public static CallUpdateResponse ToResponse(this CallUpdateResult vm)
        {
            return new CallUpdateResponse()
            {
                IdentityId = vm.IdentityId?.ToString(),
                IdentityName = vm.IdentityNickName,
            };
        }

        public static CallChannelCreateModel ToVm(this CallChannelCreateRequest request)
        {
            var callId = request.CallId.ToLong();
            if (callId == null)
            {
                throw new System.Exception("callId is invalid");
            }

            return new CallChannelCreateModel()
            {
                CallId = callId.Value,
                ChannelPeerName = request.PeerName,
                ChannelPeerTypeIndex = (Gp_TelephonySystemPeerType)request.PeerType,
                ChannelSourceId = request.RefCallChannelId,
                ChannelStatusIndex = (Gp_ChannelStatus)request.ChannelState,
                CreateDate = request.CreateDate,
                IsLive = request.IsLive,
                //TsKey = request.TsKey,
            };
        }

        public static CallChannelCreateResponse ToResponse(this CallChannelCreateResult vm)
        {
            return new CallChannelCreateResponse()
            {
                CallChannelId = vm.CallChannelId.ToString(),
            };
        }

        public static CallChannelUpdateModel ToVm(this CallChannelUpdateRequest request)
        {
            var callChannelId = request.ChannelId.ToLong();
            if (callChannelId == null)
            {
                throw new System.Exception("callId is invalid");
            }
            return new CallChannelUpdateModel()
            {
                CallChannelId = callChannelId.Value,
                ChannelStatusIndex = (Gp_ChannelStatus)request.ChannelState,
                ChannelResponseIndex = (Gp_ChannelResponse)request.ChannelResponse,
                ConnectDate = request.ConnectDate,
                HangupDate = request.HangupDate,
                IsLive = request.IsLive,
                RecordedFileName = request.RecordedFileName,
                ToChangePeerName = request.ToChangePeerName,
                ToChangePeerTypeIndex = (Gp_TelephonySystemPeerType?)request.ToChangePeerType,
                //TsKey = request.TsKey,
            };
        }

        public static CallMergeModel ToVm(this MergeCallRequest request)
        {
            return new CallMergeModel()
            {
                TsKey = request.TsKey,
                DestinationCallId = long.Parse(request.DestCallId),
                SourceCallId = long.Parse(request.SourceCallId),
            };
        }
    }
}
