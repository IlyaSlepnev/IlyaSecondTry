using Calculator.twoArguments;
using NUnit.Framework;

namespace CalculatorTests.twoArgumentsTest
{
    [TestFixture]
    public class MultiplicationTest
    {
        [TestCase(7, 0, 0)]
        [TestCase(3, 4, 12)]
        [TestCase(14, 2, 28)]
        public void CalculateMultiplicationTest(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = new Multiplication();
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);

        }
    }
