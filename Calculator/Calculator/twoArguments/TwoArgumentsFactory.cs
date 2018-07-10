using System;

namespace Calculator.twoArguments
{
    public class TwoArgumentsFactory
    {
        /// <summary>
        /// Switch One Argument Calculator
        /// </summary>
        /// <param name="calculatorname"></param>
        /// <returns>
        /// Method
        /// </returns>
        public static ITwoArgumentsCalculator CreateCalculator(string calculatorname)
        {
            switch (calculatorname)
            {
                case "SolutionPlus": return new Plus();
                case "SolutionMinus": return new Minus();
                case "SolutionMulti": return new Multiplication();
                case "SolutionDiv": return new Division();
                case "SolutionDegree": return new Degree();
                case "DegreeFraction": return new DegreeFraction();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }

}