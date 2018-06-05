using Lob.Api.Common;
using Lob.Common;
using Lob.Common.Utils;
using Lob.Protocol;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Lob.Api.Address
{
    public class AddressClient
    {
        public AddressClient(LobRestClient client)
        {
            Client = client;
        }

        private LobRestClient Client { get; set; }

        public Task<LobResponse<DeletableResource>> DeleteAsync(string id)
        {
            return Client.ExecuteAsync<DeletableResource>(
                HttpMethod.Delete,
                $"{Constants.AddressResourceEndpoint}/{id}"
                );
        }

        public Task<LobResponse<AddressResource>> GetAsync(string id)
        {
            return Client.ExecuteAsync<AddressResource>(
                HttpMethod.Get,
                $"{Constants.AddressResourceEndpoint}/{id}"
                );
        }

        // TODO: ListOptions
        public Task<LobResponse<LobCollection<AddressResource>>> ListAsync()
        {
            return Client.ExecuteAsync<LobCollection<AddressResource>>(
                HttpMethod.Get,
                Constants.AddressResourceEndpoint
                );
        }

        public Task<LobResponse<AddressResource>> CreateAsync(
                string addressLine1,
                string addressLine2 = null,
                string addressCity = null,
                string addressState = null,
                string addressZip = null,
                string addressCountry = null,
                string description = null,
                string name = null,
                string company = null,
                string phone = null,
                string email = null,
                IDictionary<string, string> metadata = null)
        {
            return CreateAsync(
                new CreateAddressRequest()
                {
                    Description = description,
                    Name = name,
                    Company = company,
                    AddressLine1 = addressLine1,
                    AddressLine2 = addressLine2,
                    AddressCity = addressCity,
                    AddressState = addressState,
                    AddressZip = addressZip,
                    AddressCountry = addressCountry,
                    Phone = phone,
                    Email = email,
                    Metadata = metadata
                });
        }

        public Task<LobResponse<AddressResource>> CreateAsync(CreateAddressRequest options)
        {
            return Client.ExecuteAsync<AddressResource>(
                HttpMethod.Post,
                Constants.AddressResourceEndpoint,
                 HttpContentFactory.CreateJsonContent(options)
                );
        }
    }
}
