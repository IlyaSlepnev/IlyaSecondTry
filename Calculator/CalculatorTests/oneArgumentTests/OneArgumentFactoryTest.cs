using System;
using Calculator.oneArgument;
using Nunit.Framework;

namespace CalculatorTests.FactoryTest
{

    public class OneArgumentFactoryTest
    {
        [TestCase("radicalSolution", typeof(Radical))]
        [TestCase("sinSolution", typeof(Sinus))]
        [TestCase("cosSolution", typeof(Сosine))]
        [TestCase("tanSolution", typeof(Tangent))]

        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);

        }
    }
}