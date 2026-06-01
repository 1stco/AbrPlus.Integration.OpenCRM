namespace AbrPlus.Integration.OpenCRM.Requests
{
    public class MergeCallRequest
    {
        public string TsKey { get; set; }
        public string SourceCallId { get; set; }
        public string DestCallId { get; set; }
        public string RefSourceCallId { get; set; }
        public string RefDestCallId { get; set; }
    }
}
