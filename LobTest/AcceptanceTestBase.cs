using Lob;
using NUnit.Framework;

namespace LobTest
{
    [TestFixture(Category = "Acceptance")]
    public abstract class AcceptanceTestBase
    {
        [SetUp]
        public virtual void Setup()
        {
            LobClient = new LobClient("test_08423401b0a727b2301faf21570effdf984");
        }

        public LobClient LobClient { get; set; }
    }
}
