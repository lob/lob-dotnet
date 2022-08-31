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
    public class BillingGroupsApiTests : IDisposable
    {
        private BillingGroupsApi validApi;
        private BillingGroupsApi invalidApi;
        private BillingGroupEditable billingGroupEditable;
        private BillingGroupEditable updatedBillingGroupEditable;

        public BillingGroupsApiTests()
        {
            Configuration config = new Configuration();
            Configuration invalidConfig = new Configuration();

            DotNetEnv.Env.TraversePath().Load();
            config.Username = System.Environment.GetEnvironmentVariable("LOB_API_TEST_KEY");
            invalidConfig.Username = "fake api key";

            validApi = new BillingGroupsApi(config);
            invalidApi = new BillingGroupsApi(invalidConfig);

            billingGroupEditable = new BillingGroupEditable(
                "Test Billing Group Created", // description
                "TestBillingGroup1" // name
            );

            updatedBillingGroupEditable = new BillingGroupEditable(
              "updated billing group",
              "UpdatedBGName"
            );
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        [Test]
        public void BillingGroupCreateTest() {
            BillingGroup response = validApi.BillingGroupCreate(billingGroupEditable);

            Assert.NotNull(response.Id);
            Assert.AreEqual(response.Description, billingGroupEditable.Description);
        }

        [Test]
        public void BillingGroupCreateTestBadParameter() {
            try {
                BillingGroup response = validApi.BillingGroupCreate(null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Missing required parameter 'billingGroupEditable'"));
            }
        }

        [Test]
        public void BillingGroupCreateTestBadUsername() {
            try {
                BillingGroup response = invalidApi.BillingGroupCreate(billingGroupEditable);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Your API key is not valid"));
            }
        }

        [Test]
        public void BillingGroupUpdateTest() {
            BillingGroup bg = validApi.BillingGroupCreate(billingGroupEditable);
            BillingGroup response = validApi.BillingGroupUpdate(bg.Id, updatedBillingGroupEditable);

            Assert.NotNull(response);
            Assert.AreEqual(response.Id, bg.Id);
            Assert.AreEqual(response.Description, updatedBillingGroupEditable.Description);
        }

        [Test]
        public void BillingGroupUpdateTestBadParameter() {
            try {
                BillingGroup response = validApi.BillingGroupUpdate(null, null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Missing required parameter 'bgId'"));
            }
        }

        [Test]
        public void BillingGroupUpdateTestBadUsername() {
            BillingGroup bg = validApi.BillingGroupCreate(billingGroupEditable);
            try {
                BillingGroup response = invalidApi.BillingGroupUpdate(bg.Id, updatedBillingGroupEditable);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Your API key is not valid"));
            }
        }

        [Test]
        public void BillingGroupRetrieveTest() {
            BillingGroup bg = validApi.BillingGroupCreate(billingGroupEditable);
            BillingGroup response = validApi.BillingGroupRetrieve(bg.Id);

            Assert.NotNull(response.Id);
            Assert.AreEqual(response.Id, bg.Id);
        }

        [Test]
        public void BillingGroupRetrieveTestBadParameter() {
            try {
                BillingGroup response = validApi.BillingGroupRetrieve(null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Missing required parameter 'bgId'"));
            }
        }

        [Test]
        public void BillingGroupRetrieveTestBadUsername() {
            BillingGroup bg = validApi.BillingGroupCreate(billingGroupEditable);
            try {
                BillingGroup response = invalidApi.BillingGroupRetrieve(bg.Id);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Your API key is not valid"));
            }
        }

        [Test]
        public void BillingGroupListTest() {
            BillingGroupList response = validApi.BillingGroupsList(null, null, null, null, null, null);

            Assert.Greater(response.Count, 0);
        }

        [Test]
        public void BillingGroupListTestWithLimitParameter() {
            int limit = 2;
            BillingGroupList response = validApi.BillingGroupsList(limit, null, null, null, null, null);

            Assert.AreEqual(response.Count, 2);
        }

        [Test]
        public void BillingGroupListTestWithOffsetParameter() {
            int offset = 2;

            BillingGroupList response = validApi.BillingGroupsList(null, offset, null, null, null, null);

            Assert.Greater(response.Count, 0);
        }

        [Test]
        public void BillingGroupListTestWithIncludeParameter() {
            List<string> includeList = new List<string>();
            includeList.Add("total_count");

            BillingGroupList response = validApi.BillingGroupsList(null, null, includeList, null, null, null);
            Assert.Greater(response.Count, 0);
            // Assert.NotNull(response.TotalCount);
        }

        [Test]
        public void BillingGroupListTestWithDateCreatedParameter() {
            Dictionary<String, DateTime> dateCreated = new Dictionary<String, DateTime>();
            DateTime lastMonth = DateTime.Today.AddMonths(-1);
            dateCreated.Add("lt", lastMonth);

            BillingGroupList response = validApi.BillingGroupsList(null, null, null, dateCreated, null, null);
            Assert.Greater(response.Count, 0);
        }

        [Test]
        public void BillingGroupListTestWithDateModifiedParameter() {
            Dictionary<String, String> dateModified = new Dictionary<String, String>();
            DateTime lastMonth = DateTime.Today.AddMonths(-1);
            dateModified.Add("lt", lastMonth.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz"));

            BillingGroupList response = validApi.BillingGroupsList(null, null, null, null, dateModified, null);
            Assert.Greater(response.Count, 0);
        }

        [Test]
        public void BillingGroupListTestWithSortByParameter() {
            SortByDateModified sortBy = new SortByDateModified(null, SortByDateModified.DateModifiedEnum.Asc);
            BillingGroupList response = validApi.BillingGroupsList(null, null, null, null, null, sortBy);
            Assert.Greater(response.Count, 0);
        }
    }
}
