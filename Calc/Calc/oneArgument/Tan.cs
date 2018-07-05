using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.oneArgument
{
    public class Tan: IOneArgumentCalculator
    {
        public double Calculate(double thirdArgument)
        {
            return Math.Tan(thirdArgument);
        }
    }
}
