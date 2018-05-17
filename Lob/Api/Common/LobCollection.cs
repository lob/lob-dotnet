using System.Collections.Generic;

namespace Lob.Api.Common
{
    public class LobCollection<T>
    {
        public int Count { get; set; }
        public IList<T> Data { get; set; }
        public string Object { get; set; }
    }
}
