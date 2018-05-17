using System.Collections.Generic;

namespace Lob.Protocol
{
    public class LobResponse<TResult>
    {
        public int HttpStatusCode { get; set; }
        public IDictionary<string, string> Headers { get; set; }
        public TResult Result { get; set; }
    }
}
