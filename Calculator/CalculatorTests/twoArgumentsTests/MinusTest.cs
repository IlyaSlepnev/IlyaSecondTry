using Calculator.twoArguments;
using NUnit.Framework;

namespace CalculatorTests.twoArgumentsTest
{
    [TestFixture]
    public class MinusTest
    {
        [TestCase(7, 0, 7)]
        [TestCase(5, 4, 1)]
        [TestCase(6, 4, 2)]
        public void CalculateMinTest(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = new Minus();
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);

        }
    }
}