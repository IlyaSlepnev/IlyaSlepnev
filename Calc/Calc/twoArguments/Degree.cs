using System;

namespace Calc.twoArguments
{
    public class Degree: ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return System.Math.Pow(firstArgument, secondArgument);
        }
    }
}
