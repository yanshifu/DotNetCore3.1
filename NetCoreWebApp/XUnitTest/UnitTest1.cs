using NetCoreWebApp.Models;
using System;
using Xunit;

namespace XUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Calculator calculator = new Calculator();
            var result = calculator.Sum(4, 5, 6);
            Assert.Equal<int>(15, result);
        }
        [Theory]
        [InlineData(3, 4, 7)]
        [InlineData(5, 6, 11)]
        [InlineData(-5, 5, 0)]
        public void Test2(int num1, int num2, int expectedResult)
        {
            Calculator calculator = new Calculator();
            var result = calculator.Sum(num1, num2);
            Assert.Equal(expectedResult, result);
        }
    }
}
