using System;

namespace Calc.oneArgument
{
    public class OneArgumentFactory
    {
        public static IOneArgumentCalculator CreateCalculator(string calculatorname)
        {
            switch (calculatorname)
            {
                case "radicalSolution": return new Radical();
                case "sinSolution": return new Sinus();
                case "cosSolution": return new Сosine();
                case "tanSolution": return new Tangent();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
