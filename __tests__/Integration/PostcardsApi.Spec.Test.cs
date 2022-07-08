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
    [Parallelizable(scope: ParallelScope.Children)]
    public class PostcardsApiTests : IDisposable
    {
        private PostcardsApi validApi;
        private PostcardsApi invalidApi;
        private PostcardEditable postcardEditable;
        private List<string> idsToDelete;

        private Address address;
        private AddressesApi validAddressesApi;

        public PostcardsApiTests()
        {
            Configuration config = new Configuration();
            Configuration invalidConfig = new Configuration();

            config.Username = Environment.GetEnvironmentVariable("LOB_API_TEST_KEY");
            invalidConfig.Username = "fake api key";

            validApi = new PostcardsApi(config);
            invalidApi = new PostcardsApi(invalidConfig);

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
            metadata.Add("internal_id", "fake internal id");

            postcardEditable = new PostcardEditable(
                address.Id, // to
                address.Id, // from
                default(PostcardSize), // size
                "C# integration test postcard", // description
                default(Dictionary<string, string>), // metadata
                default(MailType), // mailType
                default(Object), // mergeVariables
                default(DateTime), // sendDate
                "https://s3-us-west-2.amazonaws.com/public.lob.com/assets/templates/4x6_pc_template.pdf", // front
                "https://s3-us-west-2.amazonaws.com/public.lob.com/assets/templates/4x6_pc_template.pdf", // back
                default(string) // billingGroupId
            );
            postcardEditable.Metadata = new Dictionary<string, string>();
            postcardEditable.Metadata.Add("fake campaign", "fakeid");

            idsToDelete = new List<string>();
        }

        public void Dispose()
        {
            validAddressesApi.AddressDelete(address.Id);
            idsToDelete.ForEach(id => validApi.PostcardDelete(id));
        }

        [Test]
        public void PostcardCreateTest() {
            Postcard response = validApi.PostcardCreate(postcardEditable);

            Assert.NotNull(response.Id);
            Assert.AreEqual(response.Metadata, postcardEditable.Metadata);
            idsToDelete.Add(response.Id);
        }

        [Test]
        public void PostcardCreateTestBadParameter() {
            try {
                Postcard response = validApi.PostcardCreate(null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Missing required parameter 'postcardEditable'"));
            }
        }

        [Test]
        public void PostcardCreateTestBadUsername() {
            try {
                Postcard response = invalidApi.PostcardCreate(postcardEditable);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Your API key is not valid"));
            }
        }

        [Test]
        public void PostcardRetrieveTest() {
            Postcard createdPostcard = validApi.PostcardCreate(postcardEditable);
            idsToDelete.Add(createdPostcard.Id);

            Postcard retrievedPostcard = validApi.PostcardRetrieve(createdPostcard.Id);

            Assert.NotNull(retrievedPostcard.Id);
            Assert.AreEqual(retrievedPostcard.Id, createdPostcard.Id);
        }

        [Test]
        public void PostcardRetrieveTestBadParameter() {
            try {
                Postcard response = validApi.PostcardRetrieve(null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Missing required parameter"));
            }
        }

        [Test]
        public void PostcardRetrieveTestBadUsername() {
            Postcard createdPostcard = validApi.PostcardCreate(postcardEditable);
            idsToDelete.Add(createdPostcard.Id);

            try {
                Postcard response = invalidApi.PostcardRetrieve(createdPostcard.Id);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Your API key is not valid"));
            }
        }

        [Test]
        public void PostcardListTest() {
            PostcardList response = validApi.PostcardsList(null, null, null, null, null, null, null, null, null, null, null);

            Assert.Greater(response.Count, 0);
        }

        [Test]
        public void PostcardListTestWithLimitParameter() {
            int limit = 2;
            PostcardList response = validApi.PostcardsList(limit, null, null, null, null, null, null, null, null, null, null);

            Assert.AreEqual(response.Count, 2);
        }

        [Test]
        public void PostcardListTestWithIncludeParameter() {
            List<string> includeList = new List<string>();
            includeList.Add("total_count");

            PostcardList response = validApi.PostcardsList(null, null, null, includeList, null, null, null, null, null, null, null);
            Assert.Greater(response.Count, 0);
            Assert.NotNull(response.TotalCount);
        }

        /* TODO [DXP-1128]: fix unpacking dictionaries into query params
        [Test]
        public void PostcardListTestWithDateCreatedParameter() {
            Dictionary<String, String> dateCreated = new Dictionary<String, String>();
            dateCreated.Add("gt", "2020-01-01");
            dateCreated.Add("lt", "2020-01-31T12");

            PostcardList response = validApi.PostcardsList(null, null, null, null, dateCreated, null, null, null, null, null, null);
            Console.WriteLine(response);
            Assert.Greater(response.Count, 0);
        }

        [Test]
        public void PostcardListTestWithMetadataParameter() {
            Dictionary<String, String> metadata = new Dictionary<String, String>();
            metadata.Add("name", "Harry");

            PostcardList response = validApi.PostcardsList(null, null, null, null, null, metadata, null, null, null, null, null);
            Console.WriteLine(response);
            Assert.Greater(response.Count, 0);
        }
        */

        /* TODO [DXP-1128]: fix how Lob API wants an array of PostcardSize but the SDK accepts just PostcardSize
        [Test]
        public void PostcardListTestWithSizeParameter() {
            PostcardSize size = PostcardSize._4x6;
            PostcardSize[] sizeArray = {size};
            PostcardList response = validApi.PostcardsList(null, null, null, null, null, null, sizeArray);
            Assert.Greater(response.Count, 0);
        }
        */

        [Test]
        public void PostcardListTestWithScheduledParameter() {
            Boolean scheduled = true;

            PostcardList response = validApi.PostcardsList(null, null, null, null, null, null, null, scheduled);
            Assert.Greater(response.Count, 0);
        }

        /* TODO: [DXP-1128]
        [Test]
        public void PostcardListTestWithSendDateParameter() {
            Dictionary<String, String> sendDate = new Dictionary<String, String>();
            sendDate.Add("gt", "2020-01-01");
            sendDate.Add("lt", "2020-01-31T12");

            PostcardList response = validApi.PostcardsList(null, null, null, null, null, null, null, null, sendDate);
            Assert.Greater(response.Count, 0);
        }
        */

        [Test]
        public void PostcardListTestWithMailTypeParameter() {
            MailType mailType = MailType.FirstClass;

            PostcardList response = validApi.PostcardsList(null, null, null, null, null, null, null, null, null, mailType);
            Assert.GreaterOrEqual(response.Count, 0);
        }

        /*
        [Test]
        public void PostcardListTestWithSortByParameter() {
            SortBy5 sortBy = new SortBy5(null, SortBy5.SendDateEnum.Asc);

            PostcardList response = validApi.PostcardsList(null, null, null, null, null, null, null, null, null, null, sortBy);
            Assert.Greater(response.Count, 0);
        }
        */

        [Test]
        public void PostcardDeleteTest() {
            Postcard createdPostcard = validApi.PostcardCreate(postcardEditable);

            PostcardDeletion deletedPostcard = validApi.PostcardDelete(createdPostcard.Id);
            Assert.True(deletedPostcard.Deleted);
        }

        [Test]
        public void PostcardDeleteTestBadParameter() {
            try {
                PostcardDeletion deletedPostcard = validApi.PostcardDelete(null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Missing required parameter"));
            }
        }

        [Test]
        public void PostcardDeleteTestBadUsername() {
            Postcard createdPostcard = validApi.PostcardCreate(postcardEditable);
            idsToDelete.Add(createdPostcard.Id);

            try {
                PostcardDeletion deletedPostcard = invalidApi.PostcardDelete(createdPostcard.Id);
            } catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Your API key is not valid"));
            }
        }
    }
}