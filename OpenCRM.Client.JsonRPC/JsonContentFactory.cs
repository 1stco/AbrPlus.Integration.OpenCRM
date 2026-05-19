using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AbrPlus.Integration.OpenCRM.Client.JsonRPC
{

    public static class JsonContentFactory
    {
        public static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            PropertyNameCaseInsensitive = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        public static StringContent Create<T>(T value)
        {
            var json = JsonSerializer.Serialize(value, JsonOptions);

            return new StringContent(
                json,
                Encoding.UTF8,
                "application/json");
        }

        public static T Deserialize<T>(string json)
        {
            return JsonSerializer.Deserialize<T>(json, JsonOptions);
        }
    }
}
