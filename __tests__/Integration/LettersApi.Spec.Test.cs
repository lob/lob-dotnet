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
    public class LettersApiTests : IDisposable
    {
        private LettersApi validApi;
        private LettersApi invalidApi;
        private LetterEditable letterEditable;
        private List<string> idsToDelete;

        private Address address;
        private AddressesApi validAddressesApi;

        public LettersApiTests()
        {
            Configuration config = new Configuration();
            Configuration invalidConfig = new Configuration();

            DotNetEnv.Env.TraversePath().Load();
            config.Username = System.Environment.GetEnvironmentVariable("LOB_API_TEST_KEY");
            invalidConfig.Username = "fake api key";

            validApi = new LettersApi(config);
            invalidApi = new LettersApi(invalidConfig);

            AddressEditable addressEditable = new AddressEditable(
                "1313 CEMETERY LN", // addressLine1
                null, // addressLine2
                "WESTFIELD", // addressCity
                "NJ", // addressState
                "07000", // addressZip
                CountryExtended.US, // addressCountry
                "test description", // description
                "Thing T. Thing", // name
                null, // company
                null, // phone
                null, // email
                null // metadata
            );

            validAddressesApi = new AddressesApi(config);
            address = validAddressesApi.AddressCreate(addressEditable);

            Dictionary<string, string> metadata = new Dictionary<string, string>();
            metadata.Add("name", "Harry");

            letterEditable = new LetterEditable(
                null, // description
                metadata, // metadata
                default(MailType), // mailType
                null, // mergeVariables
                default(DateTime), // sendDate
                true, // color
                true, // doubleSided
                LetterEditable.AddressPlacementEnum.TopFirstPage, // addressPlacement
                default(bool), // returnEnvelope
                null, // perforatedPage
                default(LetterEditableCustomEnvelope), // customEnvelope
                address.Id, // to
                address.Id, // from
                "https://s3-us-west-2.amazonaws.com/public.lob.com/assets/us_letter_1pg.pdf", // file
                LetterEditable.ExtraServiceEnum.Certified // extraService
            );

            idsToDelete = new List<string>();
        }

        public void Dispose()
        {
            validAddressesApi.AddressDelete(address.Id);
            idsToDelete.ForEach(id => validApi.LetterCancel(id));
        }

        [Test]
        public void LetterCreateTest() {
            Letter response = validApi.LetterCreate(letterEditable);

            Assert.NotNull(response.Id);
            idsToDelete.Add(response.Id);
            Assert.AreEqual(response.Metadata, letterEditable.Metadata);
        }

        [Test]
        public void LetterCreateTestBadParameter() {
            try {
                Letter response = validApi.LetterCreate(null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Missing required parameter 'letterEditable'"));
            }
        }

        [Test]
        public void LetterCreateTestBadUsername() {
            try {
                Letter response = invalidApi.LetterCreate(letterEditable);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Your API key is not valid"));
            }
        }

        [Test]
        public void LetterRetrieveTest() {
            Letter letter = validApi.LetterCreate(letterEditable);
            idsToDelete.Add(letter.Id);
            Letter response = validApi.LetterRetrieve(letter.Id);

            Assert.NotNull(response.Id);
            Assert.AreEqual(response.Id, letter.Id);
        }

        [Test]
        public void LetterRetrieveTestBadParameter() {
            try {
                Letter response = validApi.LetterRetrieve(null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Missing required parameter 'ltrId'"));
            }
        }

        [Test]
        public void LetterRetrieveTestBadUsername() {
            Letter letter = validApi.LetterCreate(letterEditable);
            idsToDelete.Add(letter.Id);
            try {
                Letter response = invalidApi.LetterRetrieve(letter.Id);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Your API key is not valid"));
            }
        }

        [Test]
        public void LetterListTest() {
            LetterList response = validApi.LettersList(null, null, null, null, null, null, null, null, null, null, null);

            Assert.Greater(response.Count, 0);
        }

        [Test]
        public void LetterListTestWithLimitParameter() {
            int limit = 2;
            LetterList response = validApi.LettersList(limit, null, null, null, null, null, null, null, null, null, null);

            Assert.AreEqual(response.Count, 2);
        }

        [Test]
        public void LetterListTestWithIncludeParameter() {
            List<string> includeList = new List<string>();
            includeList.Add("total_count");

            LetterList response = validApi.LettersList(null, null, null, includeList);
            Assert.Greater(response.Count, 0);
            Assert.NotNull(response.TotalCount);
        }

        [Test]
        public void LetterListTestWithDateCreatedParameter() {
            Dictionary<String, DateTime> dateCreated = new Dictionary<String, DateTime>();
            DateTime lastMonth = DateTime.Today.AddMonths(-1);
            dateCreated.Add("lt", lastMonth);

            LetterList response = validApi.LettersList(null, null, null, null, dateCreated);
            Assert.Greater(response.Count, 0);
        }

        [Test]
        public void LetterListTestWithMetadataParameter() {
            Letter letter = validApi.LetterCreate(letterEditable);
            idsToDelete.Add(letter.Id);

            Dictionary<String, String> metadata = new Dictionary<String, String>();
            metadata.Add("name", "Harry");

            LetterList response = validApi.LettersList(null, null, null, null, null, metadata);
            Assert.Greater(response.Count, 0);
        }

        [Test]
        public void LetterListTestWithColorParameter() {
            Boolean color = true;

            LetterList response = validApi.LettersList(null, null, null, null, null, null, color);
            Assert.Greater(response.Count, 0);
        }

        [Test]
        public void LetterListTestWithScheduledParameter() {
            Boolean scheduled = true;

            LetterList response = validApi.LettersList(null, null, null, null, null, null, null, scheduled);
            Assert.Greater(response.Count, 0);
        }

        [Test]
        public void LetterListTestWithSendDateParameter() {
            Dictionary<String, String> sendDate = new Dictionary<String, String>();
            DateTime lastMonth = DateTime.Today.AddMonths(-1);
            sendDate.Add("lt", lastMonth.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz"));

            LetterList response = validApi.LettersList(null, null, null, null, null, null, null, null, sendDate);
            Assert.Greater(response.Count, 0);
        }

        [Test]
        public void LetterListTestWithMailTypeParameter() {
            MailType mailType = MailType.FirstClass;

            LetterList response = validApi.LettersList(null, null, null, null, null, null, null, null, null, mailType);
            Assert.GreaterOrEqual(response.Count, 0);
        }

        [Test]
        public void LetterListTestWithSortByParameter() {
            SortBy5 sortBy = new SortBy5(null, SortBy5.SendDateEnum.Asc);

            LetterList response = validApi.LettersList(null, null, null, null, null, null, null, null, null, null, sortBy);
            Assert.Greater(response.Count, 0);
        }
    }
}