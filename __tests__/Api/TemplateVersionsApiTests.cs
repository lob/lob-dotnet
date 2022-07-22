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
    ///  Class for testing TemplateVersionsApi
    /// </summary>
    [TestFixture]
    [Parallelizable(scope: ParallelScope.Self)]
    public class TemplateVersionsApiTests : IDisposable
    {
        private Mock<ITemplateVersionsApi> templateVersionsApiMock;
        private TemplateVersionList fakeTemplateVersionList;

        public TemplateVersionsApiTests()
        {
            templateVersionsApiMock = new Mock<ITemplateVersionsApi>();

            List<TemplateVersion> listOfTemplateVersions = new List<TemplateVersion>();
            TemplateVersion data1 = new TemplateVersion();
            TemplateVersion data2 = new TemplateVersion();

            data1.Id = "vrsn_fakeId1";
            data2.Id = "vrsn_fakeId2";
            listOfTemplateVersions.Add(data1);
            listOfTemplateVersions.Add(data2);

            fakeTemplateVersionList = new TemplateVersionList();

            fakeTemplateVersionList.Data = listOfTemplateVersions;
            fakeTemplateVersionList.Object = "list";
            fakeTemplateVersionList.Count = listOfTemplateVersions.Count;
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test CreateTemplateVersion
        /// </summary>
        [Test]
        public void CreateTemplateVersionTest()
        {
            TemplateVersion fakeTemplateVersion = new TemplateVersion();
            fakeTemplateVersion.Id = "vrsn_fakeId";

            TemplateVersionWritable templateVersionWritable = new TemplateVersionWritable(
                "C# templateVersions unit test description", // description
                "<html>Template Versions HTML</html>", // html
                default(EngineHtml) // engine
            );

            templateVersionsApiMock.Setup(x => x.CreateTemplateVersion("tmpl_fakeId", templateVersionWritable, It.IsAny<int>())).Returns(fakeTemplateVersion);
            TemplateVersion response = templateVersionsApiMock.Object.CreateTemplateVersion("tmpl_fakeId", templateVersionWritable);

            Assert.IsInstanceOf<TemplateVersion>(response);
            Assert.AreEqual(response.Id, "vrsn_fakeId");
        }

        /// <summary>
        /// Test CreateTemplateVersionHandlesException
        /// </summary>
        [Test]
        public void CreateTemplateVersionTestHandlesException()
        {
            TemplateVersion fakeTemplateVersion = new TemplateVersion();
            ApiException fakeException = new ApiException(
                402,
                "This is an error"
            );

            templateVersionsApiMock.Setup(x => x.CreateTemplateVersion(null, null, It.IsAny<int>())).Throws(fakeException);
            try {
                TemplateVersion response = templateVersionsApiMock.Object.CreateTemplateVersion(null, null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.AreEqual(e.Message, fakeException.Message);
            }
        }

        /// <summary>
        /// Test TemplateVersionDelete
        /// </summary>
        [Test]
        public void TemplateVersionDeleteTest()
        {
            TemplateVersionDeletion fakeTemplateVersion = new TemplateVersionDeletion();

            fakeTemplateVersion.Id = "vrsn_fakeId";
            fakeTemplateVersion.Deleted = true;

            templateVersionsApiMock.Setup(x => x.TemplateVersionDelete("tmpl_fakeId", fakeTemplateVersion.Id, It.IsAny<int>())).Returns(fakeTemplateVersion);

            var response = templateVersionsApiMock.Object.TemplateVersionDelete("tmpl_fakeId", fakeTemplateVersion.Id);

            Assert.IsInstanceOf<TemplateVersionDeletion>(response);
            Assert.AreEqual(response.Deleted, fakeTemplateVersion.Deleted);
            Assert.AreEqual(response.Id, fakeTemplateVersion.Id);
        }

        /// <summary>
        /// Test TemplateVersionDeleteHandlesException
        /// </summary>
        [Test]
        public void TemplateVersionDeleteHandlesException()
        {
            ApiException fakeException = new ApiException(
                402,
                "This is an error"
            );

            templateVersionsApiMock.Setup(x => x.TemplateVersionDelete(null, null, It.IsAny<int>())).Throws(fakeException);
            try {
                var response = templateVersionsApiMock.Object.TemplateVersionDelete(null, null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.AreEqual(e.Message, fakeException.Message);
            }
        }

        /// <summary>
        /// Test TemplateVersionRetrieve
        /// </summary>
        [Test]
        public void TemplateVersionRetrieveTest()
        {
            TemplateVersion fakeTemplateVersion = new TemplateVersion();

            fakeTemplateVersion.Id = "vrsn_fakeId";
            templateVersionsApiMock.Setup(x => x.TemplateVersionRetrieve("tmpl_fakeId", fakeTemplateVersion.Id, It.IsAny<int>())).Returns(fakeTemplateVersion);
            TemplateVersion response = templateVersionsApiMock.Object.TemplateVersionRetrieve("tmpl_fakeId", fakeTemplateVersion.Id);

            Assert.IsInstanceOf<TemplateVersion>(response);
            Assert.AreEqual(response.Id, fakeTemplateVersion.Id);
        }

        /// <summary>
        /// Test TemplateVersionRetrieveHandlesException
        /// </summary>
        [Test]
        public void TemplateVersionRetrieveTestHandlesException()
        {
            ApiException fakeException = new ApiException(
                402,
                "This is an error"
            );
            templateVersionsApiMock.Setup(x => x.TemplateVersionRetrieve(null, null, It.IsAny<int>())).Throws(fakeException);

            try {
                var response = templateVersionsApiMock.Object.TemplateVersionRetrieve(null, null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.AreEqual(e.Message, fakeException.Message);
            }
        }

        /// <summary>
        /// Test TemplateVersionList
        /// </summary>
        [Test]
        public void TemplateVersionListTest()
        {
            templateVersionsApiMock.Setup(x => x.TemplateVersionsList("tmpl_fakeId", null, null, null, null, null, It.IsAny<int>())).Returns(fakeTemplateVersionList);

            var response = templateVersionsApiMock.Object.TemplateVersionsList("tmpl_fakeId", null, null, null, null, null);

            Assert.IsInstanceOf<TemplateVersionList>(response);
            Assert.AreEqual(response.Count, fakeTemplateVersionList.Count);
        }

        /// <summary>
        /// Test TemplateVersionListHandlesException
        /// </summary>
        [Test]
        public void TemplateVersionListTestHandlesException()
        {
            ApiException fakeException = new ApiException(
                402,
                "This is an error"
            );
            templateVersionsApiMock.Setup(x => x.TemplateVersionsList(null, null, null, null, null, null, It.IsAny<int>())).Throws(fakeException);

            try {
                var response = templateVersionsApiMock.Object.TemplateVersionsList(null, null, null, null, null, null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.AreEqual(e.Message, fakeException.Message);
            }
        }

        /// <summary>
        /// Test TemplateVersionListWithLimitParam
        /// </summary>
        [Test]
        public void TemplateVersionListTestWithLimitParam()
        {
            int limit = 2;

            templateVersionsApiMock.Setup(x => x.TemplateVersionsList("tmpl_fakeId", limit, null, null, null, null, It.IsAny<int>())).Returns(fakeTemplateVersionList);

            var response = templateVersionsApiMock.Object.TemplateVersionsList("tmpl_fakeId", limit, null, null, null, null);

            Assert.IsInstanceOf<TemplateVersionList>(response);
            Assert.AreEqual(response.Count, fakeTemplateVersionList.Count);
        }

        /// <summary>
        /// Test TemplateVersionListWithBeforeParam
        /// </summary>
        [Test]
        public void TemplateVersionListTestWithBeforeParam()
        {
            string before = "before";

            templateVersionsApiMock.Setup(x => x.TemplateVersionsList("tmpl_fakeId", null, before, null, null, null, It.IsAny<int>())).Returns(fakeTemplateVersionList);

            var response = templateVersionsApiMock.Object.TemplateVersionsList("tmpl_fakeId", null, before, null, null, null);

            Assert.IsInstanceOf<TemplateVersionList>(response);
            Assert.AreEqual(response.Count, fakeTemplateVersionList.Count);
        }

        /// <summary>
        /// Test TemplateVersionListWithAfterParam
        /// </summary>
        [Test]
        public void TemplateVersionListTestWithAfterParam()
        {
            string after = "after";

            templateVersionsApiMock.Setup(x => x.TemplateVersionsList("tmpl_fakeId", null, null, after, null, null, It.IsAny<int>())).Returns(fakeTemplateVersionList);

            var response = templateVersionsApiMock.Object.TemplateVersionsList("tmpl_fakeId", null, null, after, null, null);

            Assert.IsInstanceOf<TemplateVersionList>(response);
            Assert.AreEqual(response.Count, fakeTemplateVersionList.Count);
        }

        /// <summary>
        /// Test TemplateVersionListWithIncludeParam
        /// </summary>
        [Test]
        public void TemplateVersionListTestWithIncludeParam()
        {
            List<string> include = new List<string>();
            include.Add("total_count");

            templateVersionsApiMock.Setup(x => x.TemplateVersionsList("tmpl_fakeId", null, null, null, include, null, It.IsAny<int>())).Returns(fakeTemplateVersionList);

            var response = templateVersionsApiMock.Object.TemplateVersionsList("tmpl_fakeId", null, null, null, include, null);

            Assert.IsInstanceOf<TemplateVersionList>(response);
            Assert.AreEqual(response.Count, fakeTemplateVersionList.Count);
        }

        /// <summary>
        /// Test TemplateVersionListWithDateCreatedParam
        /// </summary>
        [Test]
        public void TemplateVersionListTestWithDateCreatedParam()
        {
            Dictionary<String, DateTime> dateCreated = new Dictionary<String, DateTime>();
            dateCreated.Add("gt", DateTime.Now);
            dateCreated.Add("lt", DateTime.Now);

            templateVersionsApiMock.Setup(x => x.TemplateVersionsList("tmpl_fakeId", null, null, null, null, dateCreated, It.IsAny<int>())).Returns(fakeTemplateVersionList);

            var response = templateVersionsApiMock.Object.TemplateVersionsList("tmpl_fakeId", null, null, null, null, dateCreated);

            Assert.IsInstanceOf<TemplateVersionList>(response);
            Assert.AreEqual(response.Count, fakeTemplateVersionList.Count);
        }

        /// <summary>
        /// Test TemplateVersionUpdate
        /// </summary>
        [Test]
        public void TemplateVersionUpdateTest()
        {
            TemplateVersionUpdatable templateVersionUpdate = new TemplateVersionUpdatable("C# unit test templateVersion update description");

            TemplateVersion fakeTemplateVersion = new TemplateVersion();
            fakeTemplateVersion.Id = "vrsn_fakeId";

            templateVersionsApiMock.Setup(x => x.TemplateVersionUpdate("tmpl_fakeId", fakeTemplateVersion.Id, templateVersionUpdate, It.IsAny<int>())).Returns(fakeTemplateVersion);

            TemplateVersion response = templateVersionsApiMock.Object.TemplateVersionUpdate("tmpl_fakeId", fakeTemplateVersion.Id, templateVersionUpdate);

            Assert.IsInstanceOf<TemplateVersion>(response);
            Assert.AreEqual(response.Description, fakeTemplateVersion.Description);
        }

        /// <summary>
        /// Test TemplateVersionUpdateHandlesException
        /// </summary>
        [Test]
        public void TemplateVersionUpdateTestHandlesException()
        {
            ApiException fakeException = new ApiException(
                402,
                "This is an error"
            );
            templateVersionsApiMock.Setup(x => x.TemplateVersionUpdate(null, null, null, It.IsAny<int>())).Throws(fakeException);

            try {
                var response = templateVersionsApiMock.Object.TemplateVersionUpdate(null, null, null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.AreEqual(e.Message, fakeException.Message);
            }
        }
    }
}
