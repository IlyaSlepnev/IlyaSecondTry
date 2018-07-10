using System;

namespace Calculator.oneArgument
{
    public class Сosine : IOneArgumentCalculator
    {
        /// <summary>
        /// Cosine count with one argument
        /// </summary>
        /// <param name="thirdArgument"></param>
        /// <returns>
        /// thirdArgument equals cos count
        /// </returns>
        public double Calculate(double thirdArgument)
        {
            return Math.Cos(thirdArgument);
        }
    }
}