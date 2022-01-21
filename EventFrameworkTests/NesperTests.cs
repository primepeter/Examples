using Assets.AR_VR_WrapperFramework;
using NUnit.Framework;

namespace EventFrameworkTests
{
    public class NesperTests
    {
        public Nesper NesperTestKlasse;

        [SetUp]
        public void Setup()
        {
            NesperTestKlasse = new Nesper();
        }

        [Test]
        public void InitTest()
        {
            Assert.DoesNotThrow(()=> NesperTestKlasse.init());
        }
    }
}