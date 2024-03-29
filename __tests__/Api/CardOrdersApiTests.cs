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
    ///  Class for testing CardOrdersApi
    /// </summary>
    [TestFixture]
    [Category("Unit")]
    [Parallelizable(scope: ParallelScope.Self)]
    public class CardOrdersApiTests : IDisposable
    {
        private Mock<ICardOrdersApi> cardOrdersApiMock;
        private CardOrder fakeCardOrder;
        private Card fakeCard;

        public CardOrdersApiTests()
        {
            cardOrdersApiMock = new Mock<ICardOrdersApi>();
            string fakeCardId = "card_fakeId";
            fakeCardOrder = new CardOrder(
                "co_fakeId", // id
                fakeCardId, // cardId
                null, // status
                0M, // inventory
                0M, // quantityOrdered
                0M, // unitPrice
                default(string), // cancelledReason
                default(DateTime), // availabilityDate
                default(DateTime), // expectedAvailabilityDate
                default(DateTime), // dateCreated
                default(DateTime), // dateModified
                default(bool), // deleted
                "card_order" // _object
            );

            fakeCard = new Card(
                fakeCardId, // id
                "fake url", // url
                false, // autoReorder
                null, // reorderQuantity
                "fake raw url", // rawUrl
                "fake front original url", // frontOriginalUrl
                "fake back original url", // backOriginalUrl
                new List<Thumbnail>(), // thumbnails
                0, // availableQuantity
                0, // pendingQuantity
                default(Card.StatusEnum), // status
                Card.OrientationEnum.Horizontal, // orientation
                0, // thresholdAmount
                default(DateTime), // dateCreated
                default(DateTime), // dateModified
                default(bool), // deleted
                Card.ObjectEnum.Card, // _object
                default(string), // description
                Card.SizeEnum._2125x3375 // size
            );
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
            CardOrderEditable cardOrderEditable = new CardOrderEditable(10000);

            cardOrdersApiMock.Setup(x => x.create("card_fakeId", cardOrderEditable, It.IsAny<int>())).Returns(fakeCardOrder);
            CardOrder response = cardOrdersApiMock.Object.create("card_fakeId", cardOrderEditable);

            Assert.IsInstanceOf<CardOrder>(response);
            Assert.AreEqual(response.Id, fakeCardOrder.Id);
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

            cardOrdersApiMock.Setup(x => x.create(null, null, It.IsAny<int>())).Throws(fakeException);
            try {
                CardOrder response = cardOrdersApiMock.Object.create(null, null);
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
            CardOrderList fakeCardOrderList = new CardOrderList();
            List<CardOrder> cardOrders = new List<CardOrder>();
            cardOrders.Add(fakeCardOrder);
            fakeCardOrderList.Data = cardOrders;

            cardOrdersApiMock.Setup(x => x.get(fakeCard.Id, null, null, It.IsAny<int>())).Returns(fakeCardOrderList);
            CardOrderList response = cardOrdersApiMock.Object.get(fakeCard.Id);

            Assert.IsInstanceOf<CardOrderList>(response);

            Boolean retrievedCardOrder = false;
            foreach(var cardOrder in response.Data) {
                if (cardOrder.CardId == fakeCard.Id)
                    retrievedCardOrder = true;
            }
            Assert.True(retrievedCardOrder);
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
            cardOrdersApiMock.Setup(x => x.get("fakeId", null, null, It.IsAny<int>())).Throws(fakeException);

            try {
                var response = cardOrdersApiMock.Object.get("fakeId");
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.AreEqual(e.Message, fakeException.Message);
            }
        }
    }
}
