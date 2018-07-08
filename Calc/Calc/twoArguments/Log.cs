using System;

namespace Calc.twoArguments
{
     public class Log: ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Log(firstArgument, secondArgument);
        }
    }
}
