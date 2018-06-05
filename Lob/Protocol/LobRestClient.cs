using Lob.Common;
using Lob.Common.Utils;
using Lob.Exceptions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lob.Protocol
{
    public class LobRestClient
    {
        public LobRestClient(string apiKey, HttpClient client = null)
        {
            // TODO: HttpClient should be reused across requests
            // TODO: HttpClient should be disposed
            Client = client ?? new HttpClient();
            Client.BaseAddress = new Uri(Constants.LobApiBaseAddress);
            Client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue(Constants.UserAgentProductName, Constants.UserAgentProductVersion));
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Constants.ContentTypeJson));
            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes(apiKey + ":")));
        }

        public HttpClient Client { get; private set; }

        public async Task<LobResponse<TResult>> ExecuteAsync<TResult>(
            HttpMethod method,
            string requestUrl,
            HttpContent content = null,
            IDictionary<string, string> queryParams = null,
            LobRequestOptions requestOptions = null)
        {
            HttpRequestMessage request = new HttpRequestMessage(method, requestUrl);

            if (content != null)
            {
                request.Content = content;
            }

            if (queryParams != null)
            {
                // TODO:
            }

            var response = await Client.SendAsync(request).ConfigureAwait(false);
            return await ParseLobResponseAsync<TResult>(response);
        }

        private async Task<LobResponse<TResult>> ParseLobResponseAsync<TResult>(HttpResponseMessage response)
        {
            string content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
            {
                LobException exception = null;

                try
                {
                    exception = LobException.Parse(content);
                }
                catch (JsonException)
                {
                    exception = new LobException(message: content, httpStatusCode: (int)response.StatusCode);
                }

                throw exception;
            }

            return new LobResponse<TResult>
            {
                Result = JsonConvert.DeserializeObject<TResult>(content, SerializerSettings.DefaultJsonSerializerSettings),
                HttpStatusCode = (int)response.StatusCode,
                Headers = response.Headers
                .Where(h => Constants.AllowedResponseHeaders.Any(pattern => h.Key.StartsWith(pattern, true, CultureInfo.InvariantCulture)))
                .ToDictionary(h => h.Key, h => h.Value.FirstOrDefault())
            };
        }
    }
}
