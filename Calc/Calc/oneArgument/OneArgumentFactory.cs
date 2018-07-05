using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.oneArgument
{
    public class OneArgumentFactory
    {
        public static IOneArgumentCalculator CreateCalculator(string calculatorname)
        {
            switch (calculatorname)
            {
                case "radicalSolution": return new Radical();
                case "sinSolution": return new Sin();
                case "cosSolution": return new Cos();
                case "tanSolution": return new Tan();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
