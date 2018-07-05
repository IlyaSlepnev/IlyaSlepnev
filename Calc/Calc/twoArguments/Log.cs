using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.twoArguments
{
     public class Log: ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return System.Math.Log(firstArgument, secondArgument);
        }
    }
}
