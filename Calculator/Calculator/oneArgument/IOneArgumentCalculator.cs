using System;

namespace Calculator.oneArgument
{
    public interface IOneArgumentCalculator
    {
        /// <summary>
        /// OneArgumentCalculator interface for work with classes
        /// </summary>
        /// <param name="thirdValue"></param>
        /// <returns>
        /// thirdValue
        /// </returns>
        double Calculate(double thirdValue);
    }
}