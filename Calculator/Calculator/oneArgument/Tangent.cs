using System;

namespace Calculator.oneArgument
{
    public class Tangent : IOneArgumentCalculator
    {
        /// <summary>
        /// Tangent count with one argument
        /// </summary>
        /// <param name="thirdArgument"></param>
        /// <returns>
        /// thirdArgument equals tangent count
        /// </returns>
        public double Calculate(double thirdArgument)
        {
            return Math.Tan(thirdArgument);
        }
    }
}