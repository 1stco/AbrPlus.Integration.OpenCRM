//using AbrPlus.Platform.Client;

using AbrPlus.Integration.OpenCRM.Requests;
using AbrPlus.Integration.OpenCRM.Responses;
using AbrPlus.Platform.Client.Call;
using SeptaKit.Extensions;
using System;

namespace AbrPlus.Integration.OpenCRM.Client.AbrPlus.Mapper
{
    public static class CallMapper
    {
        public static T ParseEnum<T>(this string oldType)
        {
            return (T)Enum.Parse(typeof(T), oldType.ToString(), true);
        }

        public static CreateCallRequestVm ToVm(this CallCreateRequest request)
        {
            return new CreateCallRequestVm()
            {
                InitChannelPeerName = request.SourceInitCallChannelPeerName,
                InitChannelPeerType = request.SourceInitCallChannelPeerType.ToString().ParseEnum<PeerType>(), //(PeerType)Enum.Parse(typeof(PeerType),request.SourceInitCallChannelPeerType.ToString()), //(PeerType)request.SourceInitCallChannelPeerType,
                InitChannelSourceId = request.SourceInitCallChannelId,
                IsLive = request.IsLive,
                PhoneCallType = request.CallType.ToString().ParseEnum<CallType>(),
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
                CallTypeIndex = request.CallType.ToString().ParseEnum<CallType>(),
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
                ChannelPeerTypeIndex = request.PeerType.ToString().ParseEnum<PeerType>(),
                ChannelSourceId = request.SourceCallChannelId,
                ChannelStatus = request.ChannelState.ToString().ParseEnum<ChannelState>(),
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
                ChannelStatus = request.ChannelState.ToString().ParseEnum<ChannelState>(),
                ChannelResponse = request.ChannelResponse.ToString().ParseEnum<ChannelResponse>(),
                ConnectDate = request.ConnectDate,
                HangupDate = request.HangupDate,
                IsLive = request.IsLive,
                RecordedFileName = request.RecordedFileName,
                ToChangePeerName = request.ToChangePeerName,
                ToChangePeerTypeIndex = request.ToChangePeerType?.ToString().ParseEnum<PeerType>(),
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
