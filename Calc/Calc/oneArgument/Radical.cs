using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
