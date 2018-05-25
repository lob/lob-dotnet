using Lob.Exceptions;
using Newtonsoft.Json;
using NUnit.Framework;

namespace LobTest.Exceptions
{
    [TestFixture]
    class LobExceptionTest
    {
        [Test]
        public void TestParseJson()
        {
            const string EXPECTED_MESSAGE = "expected_message";
            const int EXPECTED_STATUS_CODE = 422;

            var json = JsonConvert.SerializeObject(new
            {
                error = new
                {
                    message = EXPECTED_MESSAGE,
                    status_code = EXPECTED_STATUS_CODE
                }
            });

            LobException exception = LobException.Parse(json);

            Assert.AreEqual(EXPECTED_MESSAGE, exception.Message);
            Assert.AreEqual(EXPECTED_STATUS_CODE, exception.HttpStatusCode);
        }
    }
}
