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
    ///  Class for testing IntlAutocompletionsApi
    /// </summary>
    [TestFixture]
    [Parallelizable(scope: ParallelScope.Self)]
    public class IntlAutocompletionsApiTests : IDisposable
    {
        private Mock<IIntlAutocompletionsApi> intlAutocompletionsApiMock;
        private IntlAutocompletionsWritable intlAutocompletionsWritable;
        private IntlSuggestions intlSuggestion;

        public IntlAutocompletionsApiTests()
        {
            intlAutocompletionsApiMock = new Mock<IIntlAutocompletionsApi>();
            intlAutocompletionsWritable = new IntlAutocompletionsWritable(
                "fake prefix", // addressPrefix
                "fake city", // city
                "XX", // state
                "12345", // zipCode
                CountryExtended.CA // country
            );

            intlSuggestion = new IntlSuggestions(
                "fake primaryNumberRange", // primaryNumberRange
                "fake primaryLine", // primaryLine
                "fake city", // city
                "XX", // state
                IntlSuggestions.CountryEnum.CA, // country
                "12345" // zipCode
            );
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test IntlAutocompletion
        /// </summary>
        [Test]
        public void IntlAutocompletionTest()
        {
            List<IntlSuggestions> intlSuggestionsList = new List<IntlSuggestions>();
            intlSuggestionsList.Add(intlSuggestion);

            IntlAutocompletions fakeIntlAutocompletions = new IntlAutocompletions("intl_auto_fakeId", intlSuggestionsList);

            intlAutocompletionsApiMock.Setup(x => x.IntlAutocompletion(intlAutocompletionsWritable, null, It.IsAny<int>())).Returns(fakeIntlAutocompletions);
            IntlAutocompletions response = intlAutocompletionsApiMock.Object.IntlAutocompletion(intlAutocompletionsWritable, null);

            Assert.IsInstanceOf<IntlAutocompletions>(response);
            Assert.NotNull(response.Suggestions);
            Assert.AreEqual(response.Suggestions.Count, 1);
        }

        /// <summary>
        /// Test IntlAutocompletionHandlesException
        /// </summary>
        [Test]
        public void IntlAutocompletionTestHandlesException()
        {
            ApiException fakeException = new ApiException(
                402,
                "This is an error"
            );

            intlAutocompletionsApiMock.Setup(x => x.IntlAutocompletion(null, null, It.IsAny<int>())).Throws(fakeException);
            try {
                IntlAutocompletions response = intlAutocompletionsApiMock.Object.IntlAutocompletion(null, null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.AreEqual(e.Message, fakeException.Message);
            }
        }
    }
}
