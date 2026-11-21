//using AbrPlus.Platform.Client;

using AbrPlus.Integration.OpenCRM.Requests;
using AbrPlus.Integration.OpenCRM.Responses;
using Payamgostar.Client.Telephony;
using SeptaKit.Extensions;
using System;

namespace AbrPlus.Integration.OpenCRM.Client.PayamGostar.Mapper
{
    public static class CallMapper
    {
        public static T ParseEnum<T>(this string oldType)
        {
            return (T)Enum.Parse(typeof(T), oldType.ToString(), true);
        }

        public static CallCreateModel ToVm(this CallCreateRequest request)
        {
            return new CallCreateModel()
            {
                InitChannelPeerName = request.InitCallChannelPeerName,
                InitChannelPeerTypeIndex = request.InitCallChannelPeerType.ToString().ParseEnum<Gp_TelephonySystemPeerType>(), //(PeerType)Enum.Parse(typeof(PeerType),request.InitCallChannelPeerType.ToString()), //(PeerType)request.InitCallChannelPeerType,
                InitChannelSourceId = request.RefInitCallChannelId,
                IsLive = request.IsLive,
                CallTypeIndex = request.CallType.ToString().ParseEnum<Gp_PhoneCallType>(),
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
                CallTypeIndex = request.CallType.ToString().ParseEnum<Gp_PhoneCallType>(),
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
                ChannelPeerTypeIndex = request.PeerType.ToString().ParseEnum<Gp_TelephonySystemPeerType>(),
                ChannelSourceId = request.RefCallChannelId,
                ChannelStatusIndex = request.ChannelState.ToString().ParseEnum<Gp_ChannelStatus>(),
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
                ChannelStatusIndex = request.ChannelState.ToString().ParseEnum<Gp_ChannelStatus>(),
                ChannelResponseIndex = request.ChannelResponse.ToString().ParseEnum<Gp_ChannelResponse>(),
                ConnectDate = request.ConnectDate,
                HangupDate = request.HangupDate,
                IsLive = request.IsLive,
                RecordedFileName = request.RecordedFileName,
                ToChangePeerName = request.ToChangePeerName,
                ToChangePeerTypeIndex = request.ToChangePeerType?.ToString().ParseEnum<Gp_TelephonySystemPeerType>(),
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
