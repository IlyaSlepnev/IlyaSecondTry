using Calculator.twoArguments;
using NUnit.Framework;

namespace CalculatorTests.twoArgumentsTest
{
    [TestFixture]
    public class PlusTest
    {
        [TestCase(7, 0, 7)]
        [TestCase(3, 4, 7)]
        [TestCase(14, -7, 7)]
        public void CalculatePlusTest(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = new Plus();
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);

        }
    }
}