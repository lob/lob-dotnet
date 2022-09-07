/*
 * Lob
 *
 * The Lob API is organized around REST. Our API is designed to have predictable, resource-oriented URLs and uses HTTP response codes to indicate any API errors. <p> Looking for our [previous documentation](https://lob.github.io/legacy-docs/)?
 *
 * The version of the OpenAPI document: 1.3.0
 * Contact: lob-openapi@lob.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using lob.dotnet.Client;
using lob.dotnet.Api;
using lob.dotnet.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace __tests__.Integration {
    [TestFixture]
    [Parallelizable(scope: ParallelScope.Self)]
    public class AddressesApiTests : IDisposable
    {
        private AddressesApi validApi;
        private AddressesApi invalidApi;
        private List<string> createdIds = new List<string>();

        public AddressesApiTests()
        {
            Configuration config = new Configuration();
            Configuration invlaidConfig = new Configuration();

            DotNetEnv.Env.TraversePath().Load();
            config.Username = System.Environment.GetEnvironmentVariable("LOB_API_TEST_KEY");
            invlaidConfig.Username = "fake api key";

            validApi = new AddressesApi(config);
            invalidApi = new AddressesApi(invlaidConfig);
        }

        public void Dispose()
        {
            foreach (string id in createdIds) {
                validApi.delete(id);
            }
        }

        [Test]
        public void createTest() {
            AddressEditable addressEditable = new AddressEditable("1313 CEMETERY LN", null, "WESTFIELD", "NJ", "07091", CountryExtended.US, "test description", "Thing T. Addams");
            Address response = validApi.create(addressEditable);

            Assert.NotNull(response.Id);
            Assert.AreEqual(response.AddressLine1, addressEditable.AddressLine1);

            createdIds.Add(response.Id);
        }

        [Test]
        public void createTestBadParameter() {
            try {
                Address response = validApi.create(null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Missing required parameter 'addressEditable'"));
            }
        }

        [Test]
        public void createTestBadUsername() {
            try {
                AddressEditable addressEditable = new AddressEditable("1313 CEMETERY LN", null, "WESTFIELD", "NJ", "07091", CountryExtended.US, "test description", "Thing T. Addams");
                Address response = invalidApi.create(addressEditable);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Your API key is not valid"));
            }
        }

        [Test]
        public void getTest() {
            Address response = validApi.get(createdIds.FirstOrDefault());

            Assert.NotNull(response.Id);
            Assert.AreEqual(response.Id, createdIds.FirstOrDefault());
        }

        [Test]
        public void getTestBadParameter() {
            try {
                Address response = validApi.get(null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Missing required parameter 'adrId'"));
            }
        }

        [Test]
        public void getTestBadUsername() {
            try {
                Address response = invalidApi.get(createdIds.FirstOrDefault());
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Your API key is not valid"));
            }
        }

                [Test]
        public void AddressListTest() {
            AddressList response = validApi.list(null, null, null, null, null, null);

            Assert.Greater(response.Count, 0);
        }

        [Test]
        public void AddressListTestWithIncludeParameter() {
            List<string> includeList = new List<string>();
            includeList.Add("total_es");
            AddressList response = validApi.list(null, null, null, includeList, null, null);

            Assert.Greater(response.Count, 0);
        }

        [Test]
        public void AddressListTestWithDateCreatedParameter() {
            Dictionary<String, DateTime> dateCreated = new Dictionary<String, DateTime>();
            DateTime lastMonth = DateTime.Today.AddMonths(-1);
            dateCreated.Add("lt", lastMonth);

            AddressList response = validApi.list(null, null, null, null, dateCreated, null);
            Assert.Greater(response.Count, 0);
        }
    }
}