using Calculator.oneArgument;
using NUnit.Framework;

namespace CalculatorTests.oneArgumentTest
{
    [TestFixture]
    public class SinusTest
    {
        [TestCase(0, 0)]
        [TestCase(90, 1)]
        [TestCase(180, 0)]
        public void CalculateSinTest(double firstValue, double expected)
        {
            IOneArgumentCalculator calculator = new Sinus();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);

        }
    }
}