using System;

namespace Calculator.twoArguments
{
    public class Degree : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Degree count with two arguments
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns>
        /// thirdArgument equals degree 
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, secondArgument);
        }
    }
}