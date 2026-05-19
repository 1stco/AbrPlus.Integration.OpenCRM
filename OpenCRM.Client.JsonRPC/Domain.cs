using System;
using System.Text.Json.Serialization;

namespace AbrPlus.Integration.OpenCRM.Client.JsonRPC
{
    public class JsonRpcRequest<TParams>
    {
        [JsonPropertyName("jsonrpc")]
        public string JsonRpc { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("method")]
        public string Method { get; set; }

        [JsonPropertyName("params")]
        public TParams Params { get; set; }

        public JsonRpcRequest()
        {
            JsonRpc = "2.0";
        }
    }

    public class JsonRpcResponse<TResult>
    {
        [JsonPropertyName("jsonrpc")]
        public string JsonRpc { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("result")]
        public TResult Result { get; set; }

        [JsonPropertyName("error")]
        public JsonRpcError Error { get; set; }
    }

    public class JsonRpcError
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("data")]
        public object Data { get; set; }
    }
}
