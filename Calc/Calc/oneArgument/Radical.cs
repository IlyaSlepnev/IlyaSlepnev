using System;

namespace Calc.oneArgument
{
    public class Radical: IOneArgumentCalculator
    {
        public double Calculate(double radical)
        {
            return System.Math.Sqrt(radical);
        }
    }
}
