using System;

namespace Calculator.oneArgument
{
    public class Radical : IOneArgumentCalculator
    {
        /// <summary>
        /// Radical count with one argument
        /// </summary>
        /// <param name="radical"></param>
        /// <returns>
        /// thirdArgument equals radical count
        /// </returns>
        public double Calculate(double radical)
        {
            return Math.Sqrt(radical);
        }
    }
}