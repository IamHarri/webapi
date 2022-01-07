using NUnit.Framework;
using Prime.Services;
// using Allure.Commons;
// using NUnit.Allure.Attributes;
// using NUnit.Allure.Core;

namespace Prime.UnitTests.Services
{
    // [TestFixture]
    // [AllureNUnit] 
    public class PrimeService_IsPrimeShould
    {
        private PrimeService _primeService;

        [SetUp]
        public void SetUp()
        {
            _primeService = new PrimeService();
        }   
        
        [Test]
        public void odd_even()
        {
            var result = _primeService.IsPrime(1);

            Assert.IsFalse(result, "even number");
        }

        [Test]
        public void Prime_equal()
        {
            var result = _primeService.equal(2,2);
            Assert.IsTrue(result,"2 so bang nhau");
        }

        [Test]
        public void Prime_equal1()
        {
            var result = _primeService.equal1(2,4);
            Assert.IsTrue(result,"2 so chia het cho 2");
        }
        [Test]
        public void Prime_equal2()
        {
            var result = _primeService.equal2(1,2,3);
            Assert.IsTrue(result, "sum less than 8");
        }
        [Test]
        public void Prime_equal3()
        {
            var result = _primeService.equal3(2);
            Assert.IsTrue(result,"this number add to 4 less than 5");
        }
    }
}