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
    [Parallelizable(scope: ParallelScope.Self)]
    public class LettersApiTests : IDisposable
    {
        private Mock<ILettersApi> LettersApiMock;
        private LetterList fakeLetterList;
        private Letter fakeLetter;

        public LettersApiTests()
        {
            LettersApiMock = new Mock<ILettersApi>();
            fakeLetter = new Letter(
              new Address(), // to
              new Address(), // from
              Letter.CarrierEnum.USPS, // carrier
              default(List<Thumbnail>), // thumbnails
              default(DateTime), // expectedDeliveryDate
              default(DateTime), // dateCreated
              default(DateTime), // dateModified
              default(bool), // deleted
              "ltr_fakeId", // id
              default(string), // templateId
              default(string), // templateVersionId
              Letter.ObjectEnum.Letter, // _object
              default(string), // description
              default(Dictionary<string, string>), // metadata
              default(Object), // mergeVariables
              default(DateTime), // sendDate
              default(string), // extraService
              default(string), // trackingNumber
              default(List<TrackingEventNormal>), // trackingEvents
              default(string), // returnAddress
              default(MailType), // mailType
              default(bool), // color
              true, // doubleSided
              Letter.AddressPlacementEnum.TopFirstPage, // addressPlacement
              default(bool), // returnEnvelope
              null, // perforatedPage
              default(LetterCustomEnvelope) // customEnvelope
            );

            List<Letter> listOfLetters = new List<Letter>();
            Letter data1 = new Letter(
              new Address(), // to
              new Address(), // from
              Letter.CarrierEnum.USPS, // carrier
              default(List<Thumbnail>), // thumbnails
              default(DateTime), // expectedDeliveryDate
              default(DateTime), // dateCreated
              default(DateTime), // dateModified
              default(bool), // deleted
              "ltr_fakeId1", // id
              default(string), // templateId
              default(string), // templateVersionId
              Letter.ObjectEnum.Letter, // _object
              default(string), // description
              default(Dictionary<string, string>), // metadata
              default(Object), // mergeVariables
              default(DateTime), // sendDate
              default(string), // extraService
              default(string), // trackingNumber
              default(List<TrackingEventNormal>), // trackingEvents
              default(string), // returnAddress
              default(MailType), // mailType
              default(bool), // color
              true, // doubleSided
              Letter.AddressPlacementEnum.TopFirstPage, // addressPlacement
              default(bool), // returnEnvelope
              null, // perforatedPage
              default(LetterCustomEnvelope) // customEnvelope
            );
            Letter data2 = new Letter(
              new Address(), // to
              new Address(), // from
              Letter.CarrierEnum.USPS, // carrier
              default(List<Thumbnail>), // thumbnails
              default(DateTime), // expectedDeliveryDate
              default(DateTime), // dateCreated
              default(DateTime), // dateModified
              default(bool), // deleted
              "ltr_fakeId2", // id
              default(string), // templateId
              default(string), // templateVersionId
              Letter.ObjectEnum.Letter, // _object
              default(string), // description
              default(Dictionary<string, string>), // metadata
              default(Object), // mergeVariables
              default(DateTime), // sendDate
              default(string), // extraService
              default(string), // trackingNumber
              default(List<TrackingEventNormal>), // trackingEvents
              default(string), // returnAddress
              default(MailType), // mailType
              default(bool), // color
              true, // doubleSided
              Letter.AddressPlacementEnum.TopFirstPage, // addressPlacement
              default(bool), // returnEnvelope
              null, // perforatedPage
              default(LetterCustomEnvelope) // customEnvelope
            );

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
        /// Test create
        /// </summary>
        [Test]
        public void createTest()
        {
            LetterEditable letterEditable = new LetterEditable(
                null, // description
                null, // metadata
                default(MailType), // mailType
                null, // mergeVariables
                default(DateTime), // sendDate
                default(bool), // color
                true, // doubleSided
                LetterEditable.AddressPlacementEnum.TopFirstPage, // addressPlacement
                default(bool), // returnEnvelope
                null, // perforatedPage
                null, // customEnvelope
                "adr_fakeId", // to
                "adr_fakeId", // from
                "https://s3-us-west-2.amazonaws.com/public.lob.com/assets/us_letter_1pg.pdf", // file
                null // extraService
            );

            LettersApiMock.Setup(x => x.create(letterEditable, null, It.IsAny<int>())).Returns(fakeLetter);
            Letter response = LettersApiMock.Object.create(letterEditable);

            Assert.IsInstanceOf<Letter>(response);
            Assert.AreEqual(response.Id, "ltr_fakeId");
        }

        /// <summary>
        /// Test createHandlesException
        /// </summary>
        [Test]
        public void createTestHandlesException()
        {
            ApiException fakeException = new ApiException(
                402,
                "This is an error"
            );

            LettersApiMock.Setup(x => x.create(null, null, It.IsAny<int>())).Throws(fakeException);
            try {
                Letter response = LettersApiMock.Object.create(null, null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.AreEqual(e.Message, fakeException.Message);
            }
        }

        /// <summary>
        /// Test cancel
        /// </summary>
        [Test]
        public void cancelTest()
        {
            LetterDeletion fakeLetter = new LetterDeletion();

            fakeLetter.Id = "ltr_fakeId";
            fakeLetter.Deleted = true;

            LettersApiMock.Setup(x => x.cancel(fakeLetter.Id, It.IsAny<int>())).Returns(fakeLetter);

            var response = LettersApiMock.Object.cancel(fakeLetter.Id);

            Assert.IsInstanceOf<LetterDeletion>(response);
            Assert.AreEqual(response.Deleted, fakeLetter.Deleted);
            Assert.AreEqual(response.Id, fakeLetter.Id);
        }

        /// <summary>
        /// Test cancelHandlesException
        /// </summary>
        [Test]
        public void cancelHandlesException()
        {
            ApiException fakeException = new ApiException(
                402,
                "This is an error"
            );

            LettersApiMock.Setup(x => x.cancel(null, It.IsAny<int>())).Throws(fakeException);
            try {
                var response = LettersApiMock.Object.cancel(null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.AreEqual(e.Message, fakeException.Message);
            }
        }

        /// <summary>
        /// Test get
        /// </summary>
        [Test]
        public void getTest()
        {
            LettersApiMock.Setup(x => x.get(fakeLetter.Id, It.IsAny<int>())).Returns(fakeLetter);
            Letter response = LettersApiMock.Object.get(fakeLetter.Id);

            Assert.IsInstanceOf<Letter>(response);
            Assert.AreEqual(response.Id, fakeLetter.Id);
        }

        /// <summary>
        /// Test getHandlesException
        /// </summary>
        [Test]
        public void getTestHandlesException()
        {
            ApiException fakeException = new ApiException(
                402,
                "This is an error"
            );
            LettersApiMock.Setup(x => x.get("ltr_fakeId", It.IsAny<int>())).Throws(fakeException);

            try {
                var response = LettersApiMock.Object.get("ltr_fakeId");
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
            LettersApiMock.Setup(x => x.list(null, null, null, null, null, null, null, null, null, null, null, It.IsAny<int>())).Returns(fakeLetterList);

            var response = LettersApiMock.Object.list(null, null, null, null, null, null, null, null, null, null, null);

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
            LettersApiMock.Setup(x => x.list(null, null, null, null, null, null, null, null, null, null, null, It.IsAny<int>())).Throws(fakeException);

            try {
                var response = LettersApiMock.Object.list(null, null, null, null, null, null, null, null, null, null, null);
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

            LettersApiMock.Setup(x => x.list(limit, null, null, null, null, null, null, null, null, null, null, It.IsAny<int>())).Returns(fakeLetterList);

            var response = LettersApiMock.Object.list(limit, null, null, null, null, null, null, null, null, null, null);

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

            LettersApiMock.Setup(x => x.list(null, before, null, null, null, null, null, null, null, null, null, It.IsAny<int>())).Returns(fakeLetterList);

            var response = LettersApiMock.Object.list(null, before, null, null, null, null, null, null, null, null, null);

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

            LettersApiMock.Setup(x => x.list(null, null, after, null, null, null, null, null, null, null, null, It.IsAny<int>())).Returns(fakeLetterList);

            var response = LettersApiMock.Object.list(null, null, after, null, null, null, null, null, null, null, null);

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

            LettersApiMock.Setup(x => x.list(null, null, null, include, null, null, null, null, null, null, null, It.IsAny<int>())).Returns(fakeLetterList);

            var response = LettersApiMock.Object.list(null, null, null, include, null, null, null, null, null, null, null);

            Assert.IsInstanceOf<LetterList>(response);
            Assert.AreEqual(response.Count, fakeLetterList.Count);
        }

        /// <summary>
        /// Test LetterListWithDateCreatedParam
        /// </summary>
        [Test]
        public void LetterListTestWithDateCreatedParam()
        {
            Dictionary<String, DateTime> dateCreated = new Dictionary<String, DateTime>();
            DateTime lastMonth = DateTime.Today.AddMonths(-1);
            dateCreated.Add("lt", lastMonth);

            LettersApiMock.Setup(x => x.list(null, null, null, null, dateCreated, null, null, null, null, null, null, It.IsAny<int>())).Returns(fakeLetterList);

            var response = LettersApiMock.Object.list(null, null, null, null, dateCreated, null, null, null, null, null, null);

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

            LettersApiMock.Setup(x => x.list(null, null, null, null, null, metadata, null, null, null, null, null, It.IsAny<int>())).Returns(fakeLetterList);

            var response = LettersApiMock.Object.list(null, null, null, null, null, metadata, null, null, null, null, null);

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

            LettersApiMock.Setup(x => x.list(null, null, null, null, null, null, color, null, null, null, null, It.IsAny<int>())).Returns(fakeLetterList);

            var response = LettersApiMock.Object.list(null, null, null, null, null, null, color, null, null, null, null);

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

            LettersApiMock.Setup(x => x.list(null, null, null, null, null, null, null, scheduled, null, null, null, It.IsAny<int>())).Returns(fakeLetterList);

            var response = LettersApiMock.Object.list(null, null, null, null, null, null, null, scheduled, null, null, null);

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

            LettersApiMock.Setup(x => x.list(null, null, null, null, null, null, null, null, sendDate, null, null, It.IsAny<int>())).Returns(fakeLetterList);

            var response = LettersApiMock.Object.list(null, null, null, null, null, null, null, null, sendDate, null, null);

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

            LettersApiMock.Setup(x => x.list(null, null, null, null, null, null, null, null, null, mailType, null, It.IsAny<int>())).Returns(fakeLetterList);

            var response = LettersApiMock.Object.list(null, null, null, null, null, null, null, null, null, mailType, null);

            Assert.IsInstanceOf<LetterList>(response);
            Assert.AreEqual(response.Count, fakeLetterList.Count);
        }

        /// <summary>
        /// Test LetterListWithSortByParam
        /// </summary>
        [Test]
        public void LetterListTestWithSortByParam()
        {
            SortBy3 sortBy = new SortBy3(null, SortBy3.SendDateEnum.Asc);

            LettersApiMock.Setup(x => x.list(null, null, null, null, null, null, null, null, null, null, sortBy, It.IsAny<int>())).Returns(fakeLetterList);

            var response = LettersApiMock.Object.list(null, null, null, null, null, null, null, null, null, null, sortBy);

            Assert.IsInstanceOf<LetterList>(response);
            Assert.AreEqual(response.Count, fakeLetterList.Count);
        }
    }
}