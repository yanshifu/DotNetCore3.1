using NetCoreWebApp.Models;
using NUnit.Framework;
namespace UnitTestFw
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            Calculator calculator = new Calculator();
            var result = calculator.Sum(5, 6, 7);
            Assert.AreEqual(18, result);
        }
    }
}
