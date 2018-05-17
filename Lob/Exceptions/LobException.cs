using Newtonsoft.Json.Linq;
using System;

namespace Lob.Exceptions
{
    class LobException : Exception
    {
        public LobException(string message, int httpStatusCode) : base(message)
        {
            HttpStatusCode = httpStatusCode;
        }

        public int HttpStatusCode { get; private set; }

        public static LobException Parse(string content)
        {
            JObject res = JObject.Parse(content);
            return new LobException(
                message: res["error"]["message"].ToString(),
                httpStatusCode: res["error"]["status_code"].ToObject<int>()
                );
        }
    }
}

