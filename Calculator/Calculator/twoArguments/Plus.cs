using System;

namespace Calculator.twoArguments
{
    public class Plus : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Plus count with two arguments
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns>
        /// firstArgument
        /// secondArgument
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}