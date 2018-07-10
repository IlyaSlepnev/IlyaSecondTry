namespace Calculator.twoArguments
{
    public interface ITwoArgumentsCalculator
    {
        /// <summary>
        /// Two arguments calculator interface
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns>
        /// firstArgument
        /// secondArgument
        /// </returns>
        double Calculate(double firstArgument, double secondArgument);
    }
}