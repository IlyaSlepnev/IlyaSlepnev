using System;

namespace Calc.oneArgument
{
    public class Tangent: IOneArgumentCalculator
    {
        public double Calculate(double thirdArgument)
        {
            return Math.Tan(thirdArgument);
        }
    }
}
