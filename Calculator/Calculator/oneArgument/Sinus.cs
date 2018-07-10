using System;

namespace Calculator.oneArgument
{
    public class Sinus : IOneArgumentCalculator
    {
        /// <summary>
        /// Sinus count with one argument
        /// </summary>
        /// <param name="thirdArgument"></param>
        /// <returns>
        /// thirdArgument equals sinus count
        /// </returns>
        public double Calculate(double thirdArgument)
        {
            return Math.Sin(thirdArgument);
        }
    }
}