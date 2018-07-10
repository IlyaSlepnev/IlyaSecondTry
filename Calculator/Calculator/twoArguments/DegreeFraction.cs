using System;

namespace Calculator.twoArguments
{
    public class DegreeFraction : ITwoArgumentsCalculator
    {
        /// <summary>
        ///  DegreeFraction count with two arguments
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns>
        /// thirdArgument equals degreeFraction
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, 1 / secondArgument);
        }
    }
}