/*
 * Lob
 *
 * The Lob API is organized around REST. Our API is designed to have predictable, resource-oriented URLs and uses HTTP response codes to indicate any API errors. <p> Looking for our [previous documentation](https://lob.github.io/legacy-docs/)?
 *
 * The version of the OpenAPI document: 1.3.0
 * Contact: lob-openapi@lob.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using NUnit.Framework;

using Moq;

using lob.dotnet.Client;
using lob.dotnet.Api;
using lob.dotnet.Model;

namespace __tests__.Api
{
    /// <summary>
    ///  Class for testing BillingGroupsApi
    /// </summary>
    [TestFixture]
    [Parallelizable(scope: ParallelScope.Self)]
    public class BillingGroupsApiTests : IDisposable
    {
        private Mock<IBillingGroupsApi> billingGroupsApiMock;
        private BillingGroupList fakeBillingGroupList;

        public BillingGroupsApiTests()
        {
            billingGroupsApiMock = new Mock<IBillingGroupsApi>();

            List<BillingGroup> listOfBillingGroups = new List<BillingGroup>();
            BillingGroup data1 = new BillingGroup();
            BillingGroup data2 = new BillingGroup();

            data1.Id = "bg_fakeId1";
            data2.Id = "bg_fakeId2";
            listOfBillingGroups.Add(data1);
            listOfBillingGroups.Add(data2);

            fakeBillingGroupList = new BillingGroupList();

            fakeBillingGroupList.Data = listOfBillingGroups;
            fakeBillingGroupList.Object = "list";
            fakeBillingGroupList.Count = listOfBillingGroups.Count;
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test BillingGroupCreate
        /// </summary>
        [Test]
        public void BillingGroupCreateTest()
        {
            BillingGroup fakeBillingGroup = new BillingGroup();
            fakeBillingGroup.Id = "bg_fakeId";

            BillingGroupEditable billingGroupEditable = new BillingGroupEditable(
                "fake billing group description",
                "fake billing group name"
            );

            billingGroupsApiMock.Setup(x => x.BillingGroupCreate(billingGroupEditable, It.IsAny<int>())).Returns(fakeBillingGroup);
            BillingGroup response = billingGroupsApiMock.Object.BillingGroupCreate(billingGroupEditable);

            Assert.IsInstanceOf<BillingGroup>(response);
            Assert.AreEqual(response.Id, "bg_fakeId");
        }

        /// <summary>
        /// Test BillingGroupCreateHandlesException
        /// </summary>
        [Test]
        public void BillingGroupCreateTestHandlesException()
        {
            BillingGroup fakeBillingGroup = new BillingGroup();
            ApiException fakeException = new ApiException(
                402,
                "This is an error"
            );

            billingGroupsApiMock.Setup(x => x.BillingGroupCreate(null, It.IsAny<int>())).Throws(fakeException);
            try {
                BillingGroup response = billingGroupsApiMock.Object.BillingGroupCreate(null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.AreEqual(e.Message, fakeException.Message);
            }
        }

        /// <summary>
        /// Test BillingGroupRetrieve
        /// </summary>
        [Test]
        public void BillingGroupRetrieveTest()
        {
            BillingGroup fakeBillingGroup = new BillingGroup();

            fakeBillingGroup.Id = "bg_fakeId";
            billingGroupsApiMock.Setup(x => x.BillingGroupRetrieve(fakeBillingGroup.Id, It.IsAny<int>())).Returns(fakeBillingGroup);
            BillingGroup response = billingGroupsApiMock.Object.BillingGroupRetrieve(fakeBillingGroup.Id);

            Assert.IsInstanceOf<BillingGroup>(response);
            Assert.AreEqual(response.Id, fakeBillingGroup.Id);
        }

        /// <summary>
        /// Test BillingGroupRetrieveHandlesException
        /// </summary>
        [Test]
        public void BillingGroupRetrieveTestHandlesException()
        {
            ApiException fakeException = new ApiException(
                402,
                "This is an error"
            );
            billingGroupsApiMock.Setup(x => x.BillingGroupRetrieve(null, It.IsAny<int>())).Throws(fakeException);

            try {
                var response = billingGroupsApiMock.Object.BillingGroupRetrieve(null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.AreEqual(e.Message, fakeException.Message);
            }
        }

        /// <summary>
        /// Test BillingGroupList
        /// </summary>
        [Test]
        public void BillingGroupListTest()
        {
            billingGroupsApiMock.Setup(x => x.BillingGroupsList(null, null, null, null, null, null, It.IsAny<int>())).Returns(fakeBillingGroupList);

            var response = billingGroupsApiMock.Object.BillingGroupsList(null, null, null, null, null, null);

            Assert.IsInstanceOf<BillingGroupList>(response);
            Assert.AreEqual(response.Count, fakeBillingGroupList.Count);
        }

        /// <summary>
        /// Test BillingGroupListHandlesException
        /// </summary>
        [Test]
        public void BillingGroupListTestHandlesException()
        {
            ApiException fakeException = new ApiException(
                402,
                "This is an error"
            );
            billingGroupsApiMock.Setup(x => x.BillingGroupsList(null, null, null, null, null, null, It.IsAny<int>())).Throws(fakeException);

            try {
                var response = billingGroupsApiMock.Object.BillingGroupsList(null, null, null, null, null, null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.AreEqual(e.Message, fakeException.Message);
            }
        }

        /// <summary>
        /// Test BillingGroupListWithLimitParam
        /// </summary>
        [Test]
        public void BillingGroupListTestWithLimitParam()
        {
            int limit = 2;

            billingGroupsApiMock.Setup(x => x.BillingGroupsList(limit, null, null, null, null, null, It.IsAny<int>())).Returns(fakeBillingGroupList);

            var response = billingGroupsApiMock.Object.BillingGroupsList(limit, null, null, null, null, null);

            Assert.IsInstanceOf<BillingGroupList>(response);
            Assert.AreEqual(response.Count, fakeBillingGroupList.Count);
        }

        /// <summary>
        /// Test BillingGroupListWithOffsetParam
        /// </summary>
        [Test]
        public void BillingGroupListTestWithOffsetParam()
        {
            int offset = 2;

            billingGroupsApiMock.Setup(x => x.BillingGroupsList(null, offset, null, null, null, null, It.IsAny<int>())).Returns(fakeBillingGroupList);

            var response = billingGroupsApiMock.Object.BillingGroupsList(null, offset, null, null, null, null);

            Assert.IsInstanceOf<BillingGroupList>(response);
            Assert.AreEqual(response.Count, fakeBillingGroupList.Count);
        }

        /// <summary>
        /// Test BillingGroupListWithIncludeParam
        /// </summary>
        [Test]
        public void BillingGroupListTestWithIncludeParam()
        {
            List<string> include = new List<string>();
            include.Add("total_count");

            billingGroupsApiMock.Setup(x => x.BillingGroupsList(null, null, include, null, null, null, It.IsAny<int>())).Returns(fakeBillingGroupList);

            var response = billingGroupsApiMock.Object.BillingGroupsList(null, null, include, null, null, null);

            Assert.IsInstanceOf<BillingGroupList>(response);
            Assert.AreEqual(response.Count, fakeBillingGroupList.Count);
        }

        /// <summary>
        /// Test BillingGroupListWithDateCreatedParam
        /// </summary>
        [Test]
        public void BillingGroupListTestWithDateCreatedParam()
        {
            Dictionary<string, string> dateCreated = new Dictionary<string, string>();
            dateCreated.Add("gt", "2020-01-01");
            dateCreated.Add("lt", "2020-01-31T12");

            billingGroupsApiMock.Setup(x => x.BillingGroupsList(null, null, null, dateCreated, null, null, It.IsAny<int>())).Returns(fakeBillingGroupList);

            var response = billingGroupsApiMock.Object.BillingGroupsList(null, null, null, dateCreated, null, null);

            Assert.IsInstanceOf<BillingGroupList>(response);
            Assert.AreEqual(response.Count, fakeBillingGroupList.Count);
        }

        /// <summary>
        /// Test BillingGroupListWithDateModifiedParam
        /// </summary>
        [Test]
        public void BillingGroupListTestWithDateModifiedParam()
        {
            Dictionary<String, String> dateModified = new Dictionary<String, String>();
            dateModified.Add("gt", "2020-01-01");
            dateModified.Add("lt", "2020-01-31T12");

            billingGroupsApiMock.Setup(x => x.BillingGroupsList(null, null, null, null, dateModified, null, It.IsAny<int>())).Returns(fakeBillingGroupList);

            var response = billingGroupsApiMock.Object.BillingGroupsList(null, null, null, null, dateModified, null);

            Assert.IsInstanceOf<BillingGroupList>(response);
            Assert.AreEqual(response.Count, fakeBillingGroupList.Count);
        }

        /// <summary>
        /// Test BillingGroupListWithSortByParam
        /// </summary>
        [Test]
        public void BillingGroupListTestWithSortByParam()
        {
            SortBy5 sortBy = new SortBy5(null, SortBy5.SendDateEnum.Desc);

            billingGroupsApiMock.Setup(x => x.BillingGroupsList(null, null, null, null, null, sortBy, It.IsAny<int>())).Returns(fakeBillingGroupList);

            var response = billingGroupsApiMock.Object.BillingGroupsList(null, null, null, null, null, sortBy);

            Assert.IsInstanceOf<BillingGroupList>(response);
            Assert.AreEqual(response.Count, fakeBillingGroupList.Count);
        }

        /// <summary>
        /// Test BillingGroupUpdate
        /// </summary>
        [Test]
        public void BillingGroupUpdateTest()
        {
            BillingGroupEditable updatedBillingGroupEditable = new BillingGroupEditable(
                "billing group updated",
                "billing group updated"
            );

            BillingGroup fakeBillingGroup = new BillingGroup();
            fakeBillingGroup.Id = "bg_fakeId";

            billingGroupsApiMock.Setup(x => x.BillingGroupUpdate(fakeBillingGroup.Id, updatedBillingGroupEditable, It.IsAny<int>())).Returns(fakeBillingGroup);

            BillingGroup response = billingGroupsApiMock.Object.BillingGroupUpdate(fakeBillingGroup.Id, updatedBillingGroupEditable);

            Assert.IsInstanceOf<BillingGroup>(response);
            Assert.AreEqual(response.Id, fakeBillingGroup.Id);
            Assert.AreEqual(response.Description, fakeBillingGroup.Description);
        }

        /// <summary>
        /// Test BillingGroupUpdateHandlesException
        /// </summary>
        [Test]
        public void BillingGroupUpdateTestHandlesException()
        {
            ApiException fakeException = new ApiException(
                402,
                "This is an error"
            );
            billingGroupsApiMock.Setup(x => x.BillingGroupUpdate(null, null, It.IsAny<int>())).Throws(fakeException);

            try {
                var response = billingGroupsApiMock.Object.BillingGroupUpdate(null, null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.AreEqual(e.Message, fakeException.Message);
            }
        }
    }
}
