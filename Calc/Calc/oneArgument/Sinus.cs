using System;

namespace Calc.oneArgument
{
    public class Sinus: IOneArgumentCalculator
    {
        public double Calculate(double thirdArgument)
        {
            return Math.Sin(thirdArgument);
        }
    }
}
