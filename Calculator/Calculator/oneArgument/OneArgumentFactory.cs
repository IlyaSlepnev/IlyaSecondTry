using System;

namespace Calculator.oneArgument
{
    public class OneArgumentFactory
    {
        /// <summary>
        /// Switch One Argument Calculator
        /// </summary>
        /// <param name="calculatorname"></param>
        /// <returns>
        /// Method
        /// </returns>
        public static IOneArgumentCalculator CreateCalculator(string calculatorname)
        {
            switch (calculatorname)
            {
                case "radicalSolution": return new Radical();
                case "sinSolution": return new Sinus();
                case "cosSolution": return new Сosine();
                case "tanSolution": return new Tangent();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}