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
    ///  Class for testing LettersApi
    /// </summary>
    [TestFixture]
    public class LettersApiTests : IDisposable
    {
        private Mock<ILettersApi> LettersApiMock;
        private LetterList fakeLetterList;

        public LettersApiTests()
        {
            LettersApiMock = new Mock<ILettersApi>();

            List<Letter> listOfLetters = new List<Letter>();
            Letter data1 = new Letter();
            Letter data2 = new Letter();

            data1.Id = "ltr_fakeId1";
            data2.Id = "ltr_fakeId2";
            listOfLetters.Add(data1);
            listOfLetters.Add(data2);

            fakeLetterList = new LetterList();

            fakeLetterList.Data = listOfLetters;
            fakeLetterList.Object = "list";
            fakeLetterList.Count = listOfLetters.Count;
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test LetterCreate
        /// </summary>
        [Test]
        public void LetterCreateTest()
        {
            Letter fakeLetter = new Letter();
            fakeLetter.Id = "ltr_fakeId";

            LetterEditable letterEditable = new LetterEditable(
                null, // description
                null, // metadata
                default(MailType), // mailType
                null, // mergeVariables
                default(DateTime), // sendDate
                default(bool), // color
                true, // doubleSided
                LetterEditable.AddressPlacementEnum.TopFirstPage, // addressPlacement
                null, // returnEnvelope
                null, // perforatedPage
                null, // customEnvelope
                "adr_fakeId", // to
                "adr_fakeId", // from
                "https://s3-us-west-2.amazonaws.com/public.lob.com/assets/us_letter_1pg.pdf", // file
                null // extraService
            );

            LettersApiMock.Setup(x => x.LetterCreate(letterEditable, null, It.IsAny<int>())).Returns(fakeLetter);
            Letter response = LettersApiMock.Object.LetterCreate(letterEditable);

            Assert.IsInstanceOf<Letter>(response);
            Assert.AreEqual(response.Id, "ltr_fakeId");
        }

        /// <summary>
        /// Test LetterCreateHandlesException
        /// </summary>
        [Test]
        public void LetterCreateTestHandlesException()
        {
            Letter fakeLetter = new Letter();
            ApiException fakeException = new ApiException(
                402,
                "This is an error"
            );

            LettersApiMock.Setup(x => x.LetterCreate(null, null, It.IsAny<int>())).Throws(fakeException);
            try {
                Letter response = LettersApiMock.Object.LetterCreate(null, null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.AreEqual(e.Message, fakeException.Message);
            }
        }

        /// <summary>
        /// Test LetterCancel
        /// </summary>
        [Test]
        public void LetterCancelTest()
        {
            LetterDeletion fakeLetter = new LetterDeletion();

            fakeLetter.Id = "ltr_fakeId";
            fakeLetter.Deleted = true;

            LettersApiMock.Setup(x => x.LetterCancel(fakeLetter.Id, It.IsAny<int>())).Returns(fakeLetter);

            var response = LettersApiMock.Object.LetterCancel(fakeLetter.Id);

            Assert.IsInstanceOf<LetterDeletion>(response);
            Assert.AreEqual(response.Deleted, fakeLetter.Deleted);
            Assert.AreEqual(response.Id, fakeLetter.Id);
        }

        /// <summary>
        /// Test LetterCancelHandlesException
        /// </summary>
        [Test]
        public void LetterCancelHandlesException()
        {
            ApiException fakeException = new ApiException(
                402,
                "This is an error"
            );

            LettersApiMock.Setup(x => x.LetterCancel(null, It.IsAny<int>())).Throws(fakeException);
            try {
                var response = LettersApiMock.Object.LetterCancel(null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.AreEqual(e.Message, fakeException.Message);
            }
        }

        /// <summary>
        /// Test LetterRetrieve
        /// </summary>
        [Test]
        public void LetterRetrieveTest()
        {
            Letter fakeLetter = new Letter();

            fakeLetter.Id = "ltr_fakeId";
            LettersApiMock.Setup(x => x.LetterRetrieve(fakeLetter.Id, It.IsAny<int>())).Returns(fakeLetter);
            Letter response = LettersApiMock.Object.LetterRetrieve(fakeLetter.Id);

            Assert.IsInstanceOf<Letter>(response);
            Assert.AreEqual(response.Id, fakeLetter.Id);
        }

        /// <summary>
        /// Test LetterRetrieveHandlesException
        /// </summary>
        [Test]
        public void LetterRetrieveTestHandlesException()
        {
            ApiException fakeException = new ApiException(
                402,
                "This is an error"
            );
            LettersApiMock.Setup(x => x.LetterRetrieve(null, It.IsAny<int>())).Throws(fakeException);

            try {
                var response = LettersApiMock.Object.LetterRetrieve(null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.AreEqual(e.Message, fakeException.Message);
            }
        }

        /// <summary>
        /// Test LetterList
        /// </summary>
        [Test]
        public void LetterListTest()
        {
            LettersApiMock.Setup(x => x.LettersList(null, null, null, null, null, null, null, null, null, null, null, It.IsAny<int>())).Returns(fakeLetterList);

            var response = LettersApiMock.Object.LettersList(null, null, null, null, null, null, null, null, null, null, null);

            Assert.IsInstanceOf<LetterList>(response);
            Assert.AreEqual(response.Count, fakeLetterList.Count);
        }

        /// <summary>
        /// Test LetterListHandlesException
        /// </summary>
        [Test]
        public void LetterListTestHandlesException()
        {
            ApiException fakeException = new ApiException(
                402,
                "This is an error"
            );
            LettersApiMock.Setup(x => x.LettersList(null, null, null, null, null, null, null, null, null, null, null, It.IsAny<int>())).Throws(fakeException);

            try {
                var response = LettersApiMock.Object.LettersList(null, null, null, null, null, null, null, null, null, null, null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.AreEqual(e.Message, fakeException.Message);
            }
        }

        /// <summary>
        /// Test LetterListWithLimitParam
        /// </summary>
        [Test]
        public void LetterListTestWithLimitParam()
        {
            int limit = 2;

            LettersApiMock.Setup(x => x.LettersList(limit, null, null, null, null, null, null, null, null, null, null, It.IsAny<int>())).Returns(fakeLetterList);

            var response = LettersApiMock.Object.LettersList(limit, null, null, null, null, null, null, null, null, null, null);

            Assert.IsInstanceOf<LetterList>(response);
            Assert.AreEqual(response.Count, fakeLetterList.Count);
        }

        /// <summary>
        /// Test LetterListWithBeforeParam
        /// </summary>
        [Test]
        public void LetterListTestWithBeforeParam()
        {
            string before = "before";

            LettersApiMock.Setup(x => x.LettersList(null, before, null, null, null, null, null, null, null, null, null, It.IsAny<int>())).Returns(fakeLetterList);

            var response = LettersApiMock.Object.LettersList(null, before, null, null, null, null, null, null, null, null, null);

            Assert.IsInstanceOf<LetterList>(response);
            Assert.AreEqual(response.Count, fakeLetterList.Count);
        }

        /// <summary>
        /// Test LetterListWithAfterParam
        /// </summary>
        [Test]
        public void LetterListTestWithAfterParam()
        {
            string after = "after";

            LettersApiMock.Setup(x => x.LettersList(null, null, after, null, null, null, null, null, null, null, null, It.IsAny<int>())).Returns(fakeLetterList);

            var response = LettersApiMock.Object.LettersList(null, null, after, null, null, null, null, null, null, null, null);

            Assert.IsInstanceOf<LetterList>(response);
            Assert.AreEqual(response.Count, fakeLetterList.Count);
        }

        /// <summary>
        /// Test LetterListWithIncludeParam
        /// </summary>
        [Test]
        public void LetterListTestWithIncludeParam()
        {
            List<string> include = new List<string>();
            include.Add("total_count");

            LettersApiMock.Setup(x => x.LettersList(null, null, null, include, null, null, null, null, null, null, null, It.IsAny<int>())).Returns(fakeLetterList);

            var response = LettersApiMock.Object.LettersList(null, null, null, include, null, null, null, null, null, null, null);

            Assert.IsInstanceOf<LetterList>(response);
            Assert.AreEqual(response.Count, fakeLetterList.Count);
        }

        /// <summary>
        /// Test LetterListWithDateCreatedParam
        /// </summary>
        [Test]
        public void LetterListTestWithDateCreatedParam()
        {
            Dictionary<String, String> dateCreated = new Dictionary<String, String>();
            dateCreated.Add("gt", "2020-01-01");
            dateCreated.Add("lt", "2020-01-31T12");

            LettersApiMock.Setup(x => x.LettersList(null, null, null, null, dateCreated, null, null, null, null, null, null, It.IsAny<int>())).Returns(fakeLetterList);

            var response = LettersApiMock.Object.LettersList(null, null, null, null, dateCreated, null, null, null, null, null, null);

            Assert.IsInstanceOf<LetterList>(response);
            Assert.AreEqual(response.Count, fakeLetterList.Count);
        }

        /// <summary>
        /// Test LetterListWithMetadataParam
        /// </summary>
        [Test]
        public void LetterListTestWithMetadataParam()
        {
            Dictionary<String, String> metadata = new Dictionary<String, String>();
            metadata.Add("name", "Harry");

            LettersApiMock.Setup(x => x.LettersList(null, null, null, null, null, metadata, null, null, null, null, null, It.IsAny<int>())).Returns(fakeLetterList);

            var response = LettersApiMock.Object.LettersList(null, null, null, null, null, metadata, null, null, null, null, null);

            Assert.IsInstanceOf<LetterList>(response);
            Assert.AreEqual(response.Count, fakeLetterList.Count);
        }

        /// <summary>
        /// Test LetterListWithColorParam
        /// </summary>
        [Test]
        public void LetterListTestWithColorParam()
        {
            Boolean color = true;

            LettersApiMock.Setup(x => x.LettersList(null, null, null, null, null, null, color, null, null, null, null, It.IsAny<int>())).Returns(fakeLetterList);

            var response = LettersApiMock.Object.LettersList(null, null, null, null, null, null, color, null, null, null, null);

            Assert.IsInstanceOf<LetterList>(response);
            Assert.AreEqual(response.Count, fakeLetterList.Count);
        }

        /// <summary>
        /// Test LetterListWithScheduledParam
        /// </summary>
        [Test]
        public void LetterListTestWithScheduledParam()
        {
            Boolean scheduled = true;

            LettersApiMock.Setup(x => x.LettersList(null, null, null, null, null, null, null, scheduled, null, null, null, It.IsAny<int>())).Returns(fakeLetterList);

            var response = LettersApiMock.Object.LettersList(null, null, null, null, null, null, null, scheduled, null, null, null);

            Assert.IsInstanceOf<LetterList>(response);
            Assert.AreEqual(response.Count, fakeLetterList.Count);
        }

        /// <summary>
        /// Test LetterListWithSendDateParam
        /// </summary>
        [Test]
        public void LetterListTestWithSendDateParam()
        {
            Dictionary<String, String> sendDate = new Dictionary<String, String>();
            sendDate.Add("gt", "2020-01-01");
            sendDate.Add("lt", "2020-01-31T12");

            LettersApiMock.Setup(x => x.LettersList(null, null, null, null, null, null, null, null, sendDate, null, null, It.IsAny<int>())).Returns(fakeLetterList);

            var response = LettersApiMock.Object.LettersList(null, null, null, null, null, null, null, null, sendDate, null, null);

            Assert.IsInstanceOf<LetterList>(response);
            Assert.AreEqual(response.Count, fakeLetterList.Count);
        }

        /// <summary>
        /// Test LetterListWithMailTypeParam
        /// </summary>
        [Test]
        public void LetterListTestWithMailTypeParam()
        {
            MailType mailType = MailType.FirstClass;

            LettersApiMock.Setup(x => x.LettersList(null, null, null, null, null, null, null, null, null, mailType, null, It.IsAny<int>())).Returns(fakeLetterList);

            var response = LettersApiMock.Object.LettersList(null, null, null, null, null, null, null, null, null, mailType, null);

            Assert.IsInstanceOf<LetterList>(response);
            Assert.AreEqual(response.Count, fakeLetterList.Count);
        }

        /// <summary>
        /// Test LetterListWithSortByParam
        /// </summary>
        [Test]
        public void LetterListTestWithSortByParam()
        {
            SortBy5 sortBy = new SortBy5(null, SortBy5.SendDateEnum.Asc);

            LettersApiMock.Setup(x => x.LettersList(null, null, null, null, null, null, null, null, null, null, sortBy, It.IsAny<int>())).Returns(fakeLetterList);

            var response = LettersApiMock.Object.LettersList(null, null, null, null, null, null, null, null, null, null, sortBy);

            Assert.IsInstanceOf<LetterList>(response);
            Assert.AreEqual(response.Count, fakeLetterList.Count);
        }
    }
}
