using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace Lob.Common.Utils
{
    public static class HttpContentFactory
    {
        public static HttpContent CreateJsonContent(object obj)
        {
            string body = JsonConvert.SerializeObject(obj, SerializerSettings.DefaultJsonSerializerSettings);
            return new StringContent(body, Encoding.UTF8, Constants.ContentTypeJson);
        }
    }
}
