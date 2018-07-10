using Calculator.oneArgument;
using NUnit.Framework;

namespace CalculatorTests.oneArgumentTests
{
    [TestFixture]
    public class CosineTest
    {
        [TestCase(0, 1)]
        [TestCase(90, 0)]
        [TestCase(180, -1)]
        public void CalculateCosineTest(double firstValue, double expected)
        {
            IOneArgumentCalculator calculator = new Сosine();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);

        }
    }
}