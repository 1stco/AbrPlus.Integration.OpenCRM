using System;

namespace AbrPlus.Integration.OpenCRM.Requests
{
    public class SubmitQueueOperatorVotingRequest
    {
        public long QueueVotingResultId { get; set; }
        public DateTime CreateDate { get; set; }
        public string ModuleCode { get; set; }
        public string ModuleName { get; set; }
        public string VotingFormCode { get; set; }
        public string VotingQuestionCode { get; set; }
        public string PeerCode { get; set; }
        public string QueueCode { get; set; }
        public string QueueName { get; set; }
        public string CallId { get; set; }
        public string CallNumber { get; set; }
        public string CallerIdNum { get; set; }
        public string CallerIdName { get; set; }
        public string CallChannelId { get; set; }
        public string CustomerId { get; set; }
        public string CustomerNo { get; set; }
        public string Input { get; set; }
        public bool IsValid { get; set; }
    }
}
