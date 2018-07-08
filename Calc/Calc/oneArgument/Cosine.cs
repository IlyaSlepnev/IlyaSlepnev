using System;

namespace Calc.oneArgument
{
    public class Сosine: IOneArgumentCalculator
    {
        public double Calculate(double thirdArgument)
        {
            return Math.Cos(thirdArgument);
        }
    }
}
