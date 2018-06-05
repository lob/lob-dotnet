using Newtonsoft.Json.Linq;
using System;

namespace Lob.Exceptions
{
   public class LobException : Exception
    {
        public LobException(string message, int httpStatusCode) : base(message)
        {
            HttpStatusCode = httpStatusCode;
        }

        public int HttpStatusCode { get; private set; }

        public static LobException Parse(string json)
        {
            JObject res = JObject.Parse(json);
            return new LobException(
                message: res["error"]["message"].ToString(),
                httpStatusCode: res["error"]["status_code"].ToObject<int>()
                );
        }
    }
}

