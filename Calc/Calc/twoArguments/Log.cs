using System;

namespace Calc.twoArguments
{
     public class Log: ITwoArgumentsCalculator
    {
        /// <summary>
        /// Log count with two arguments
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns>
        /// firstArgument
        /// secondArgument
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Log(firstArgument, secondArgument);
        }
    }
}
