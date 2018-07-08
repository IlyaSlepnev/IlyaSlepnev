using System;

namespace Calc.twoArguments
{
     public class DegreeFraction: ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return System.Math.Pow(firstArgument, 1 / secondArgument);
        }
    }
}
