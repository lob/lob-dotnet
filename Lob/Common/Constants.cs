namespace Lob.Common
{
    public static class Constants
    {
        public const string ContentTypeJson = "application/json";

        public const string UserAgentProductName = "Lob-DotNet";
        public const string UserAgentProductVersion = "0.0.1";

        public const string AddressResourceEndpoint = "addresses";
        public const string LobApiBaseAddress = "https://api.lob.com/v1/";

        public const string RateLimitHeaderPrefix = "rate-limit";
        public static readonly string[] AllowedResponseHeaders = { Constants.RateLimitHeaderPrefix };
    }
}
