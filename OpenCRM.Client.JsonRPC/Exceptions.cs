using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace AbrPlus.Integration.OpenCRM.Client.JsonRPC
{

    public class CallStoreHttpException : Exception
    {
        public HttpStatusCode StatusCode { get; private set; }
        public string ResponseBody { get; private set; }

        public CallStoreHttpException(HttpStatusCode statusCode, string responseBody)
            : base(string.Format("CallStore HTTP error. StatusCode: {0} {1}", (int)statusCode, statusCode))
        {
            StatusCode = statusCode;
            ResponseBody = responseBody;
        }
    }

    public class CallStoreJsonRpcException : Exception
    {
        public int Code { get; private set; }
        public object Data { get; private set; }
        public string RpcId { get; private set; }

        public CallStoreJsonRpcException(int code, string message, object data, string rpcId)
            : base(string.Format("CallStore JSON-RPC error. Code: {0}, Message: {1}", code, message))
        {
            Code = code;
            Data = data;
            RpcId = rpcId;
        }
    }

    public class CallStoreInvalidJsonException : Exception
    {
        public string ResponseBody { get; private set; }

        public CallStoreInvalidJsonException(string responseBody)
            : base("CallStore returned invalid JSON.")
        {
            ResponseBody = responseBody;
        }

        public CallStoreInvalidJsonException(string responseBody, Exception innerException)
            : base("CallStore returned invalid JSON.", innerException)
        {
            ResponseBody = responseBody;
        }
    }

    public class CallStoreInvalidJsonRpcResponseException : Exception
    {
        public string ResponseBody { get; private set; }

        public CallStoreInvalidJsonRpcResponseException(string message, string responseBody)
            : base(message)
        {
            ResponseBody = responseBody;
        }
    }
}
