using Lob;
using Lob.Api.Address;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LobTest.Api.Address
{
    public class AddressClientAcceptanceTest : AcceptanceTestBase
    {
        public readonly AddressResource ADDRESS = new AddressResource
        {
            Description = "Harry - Office",
            Name = "HARRY",
            Company = "COMPANY",
            Email = "test@lob.com",
            Phone = "some phone",
            AddressLine1 = "185 BERRY ST STE 6100",
            AddressCity = "SAN FRANCISCO",
            AddressState = "CA",
            AddressZip = "94107-1741",
            AddressCountry = "UNITED STATES",
            Metadata = new Dictionary<string, string>
            {
                ["foo"] = "bar",
                ["fizz"] = "buzz"
            },
            Object = "address"
        };

        [Test]
        public async Task TestCreateAsync()
        {
            var response = await LobClient.Address.CreateAsync(
                description: ADDRESS.Description,
                name: ADDRESS.Name,
                company: ADDRESS.Company,
                email: ADDRESS.Email,
                phone: ADDRESS.Phone,
                addressLine1: ADDRESS.AddressLine1,
                addressCity: ADDRESS.AddressCity,
                addressState: ADDRESS.AddressState,
                addressZip: ADDRESS.AddressZip,
                addressCountry: "US",
                metadata: ADDRESS.Metadata
            );

            var address = response.Result;

            Assert.AreEqual(200, response.HttpStatusCode);
            StringAssert.AreEqualIgnoringCase(ADDRESS.Description, address.Description);
            StringAssert.AreEqualIgnoringCase(ADDRESS.Name, address.Name);
            StringAssert.AreEqualIgnoringCase(ADDRESS.Company, address.Company);
            StringAssert.AreEqualIgnoringCase(ADDRESS.Email, address.Email);
            StringAssert.AreEqualIgnoringCase(ADDRESS.Phone, address.Phone);
            CollectionAssert.AreEquivalent(ADDRESS.Metadata, address.Metadata);
            Assert.AreEqual(ADDRESS.AddressLine1, address.AddressLine1);
            Assert.AreEqual(ADDRESS.AddressCity, address.AddressCity);
            Assert.AreEqual(ADDRESS.AddressState, address.AddressState);
            Assert.AreEqual(ADDRESS.AddressZip, address.AddressZip);
            Assert.AreEqual(ADDRESS.AddressCountry, address.AddressCountry);
            Assert.AreNotEqual(address.DateCreated, default(DateTime));
            Assert.AreNotEqual(address.DateModified, default(DateTime));
            Assert.IsFalse(String.IsNullOrEmpty(address.Id));
            Assert.IsFalse(address.Deleted);
            Assert.AreEqual(ADDRESS.Object, address.Object);
        }

        [Test]
        public async Task TestDeleteAsync()
        {
            var address = (await LobClient.Address.CreateAsync(
                new CreateAddressRequest()
                {
                    Description = ADDRESS.Description,
                    Name = ADDRESS.Name,
                    Company = ADDRESS.Company,
                    Email = ADDRESS.Email,
                    Phone = ADDRESS.Phone,
                    AddressLine1 = ADDRESS.AddressLine1,
                    AddressCity = ADDRESS.AddressCity,
                    AddressState = ADDRESS.AddressState,
                    AddressZip = ADDRESS.AddressZip,
                    AddressCountry = "US",
                    Metadata = ADDRESS.Metadata
                }
            )).Result;

            var response = await LobClient.Address.DeleteAsync(address.Id);

            Assert.AreEqual(200, response.HttpStatusCode);
            Assert.AreEqual(address.Id, response.Result.Id);
            Assert.True(response.Result.Deleted);
        }

        [Test]
        public async Task TestGetAsync()
        {
            var address = (await LobClient.Address.ListAsync()).Result.Data.First();
            var response = await LobClient.Address.GetAsync(address.Id);

            Assert.AreEqual(200, response.HttpStatusCode);
            AssertAddressEquals(address, response.Result);
        }

        [Test]
        public async Task TestListAsync()
        {
            var response = await LobClient.Address.ListAsync();

            Assert.AreEqual(200, response.HttpStatusCode);
            Assert.GreaterOrEqual(response.Result.Data.Count, 1);
            Assert.GreaterOrEqual(response.Result.Count, 1);
            Assert.AreEqual("list", response.Result.Object);
        }

        private static void AssertAddressEquals(AddressResource x, AddressResource y)
        {
            Assert.AreEqual(x.Id, y.Id);
            Assert.AreEqual(x.DateCreated, y.DateCreated);
            Assert.AreEqual(x.DateModified, y.DateModified);
            Assert.AreEqual(x.Deleted, y.Deleted);
            Assert.AreEqual(x.Description, y.Description);
            Assert.AreEqual(x.Email, y.Email);
            Assert.AreEqual(x.Name, y.Name);
            Assert.AreEqual(x.Object, y.Object);
            Assert.AreEqual(x.Phone, y.Phone);
            Assert.AreEqual(x.AddressCity, y.AddressCity);
            Assert.AreEqual(x.AddressCountry, y.AddressCountry);
            Assert.AreEqual(x.AddressLine1, y.AddressLine1);
            Assert.AreEqual(x.AddressLine2, y.AddressLine2);
            Assert.AreEqual(x.AddressState, y.AddressState);
            Assert.AreEqual(x.AddressZip, y.AddressZip);
            Assert.AreEqual(x.Company, y.Company);
        }
    }
}

