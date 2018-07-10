using System;
using Calculator.twoArguments;
using NUnit.Framework;

namespace CalculatorTests.twoArgumentsTest
{
    [TestFixture]
    public class DivisionTest
    {
        [TestCase(7, 0, 1)]
        [TestCase(8, 4, 2)]
        [TestCase(14, -7, -2)]
        public void CalculateDivisionTest(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = new Division();
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void CalculateDivisionTest()
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("SolutionDiv");
            Assert.Throws<Exception>(() => calculator.Calculate(7, 0));
        }
    }
}