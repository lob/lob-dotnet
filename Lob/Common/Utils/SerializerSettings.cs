using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Lob.Common.Utils
{
    public static class SerializerSettings
    {
        public static JsonSerializerSettings DefaultJsonSerializerSettings
        {
            get
            {
                return new JsonSerializerSettings()
                {
                    ContractResolver = new DefaultContractResolver() { NamingStrategy = new SnakeCaseNamingStrategy() },
                    Formatting = Formatting.Indented
                };
            }
        }
    }
}
