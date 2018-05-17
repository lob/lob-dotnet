using Lob.Api.Address;
using Lob.Protocol;
using System;

namespace Lob
{
    public class LobClient
    {
        public LobClient(string apiKey)
        {
            if (String.IsNullOrWhiteSpace(apiKey))
            {
                throw new ArgumentOutOfRangeException("ApiKey cannot be null or white space");
            }

            ApiKey = apiKey;
        }

        public AddressClient Address => new AddressClient(LobRestClient);

        internal string ApiKey { get; private set; }
        internal LobRestClient LobRestClient => new LobRestClient(ApiKey);
    }
}
