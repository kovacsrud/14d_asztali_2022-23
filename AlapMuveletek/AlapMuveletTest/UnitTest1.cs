using NUnit.Framework;
using AlapMuveletek;

namespace AlapMuveletTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
                

        [Test]
        [TestCase(10,20,30)]
        [TestCase(20, 20, 40)]
        [TestCase(40, 20, 60)]
        public void OsszeadTest(double a,double b,double elvart)
        {
            Alapmuvelet alapmuvelet = new Alapmuvelet();
            var sut = alapmuvelet.Osszead(a, b);

            Assert.AreEqual(elvart, sut);
            
        }
    }
}