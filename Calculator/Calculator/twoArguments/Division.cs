using System;

namespace Calculator.twoArguments
{
    public class Division : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Divison count with two arguments
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns>
        /// thirdArgument equals division count
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("Деление на 0");
            }
            return firstArgument / secondArgument;
        }
    }
}