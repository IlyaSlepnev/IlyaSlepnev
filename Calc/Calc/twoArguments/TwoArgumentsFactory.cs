using System;

namespace Calc.twoArguments
{
    public class TwoArgumentsFactory
    { 
    public static ITwoArgumentsCalculator CreateCalculator(string calculatorname)
    {
        switch (calculatorname)
        {
            case "SolutionPlus": return new Plus();
            case "SolutionMinus": return new Minus();
            case "SolutionMulti": return new Multiplication();
            case "SolutionDiv": return new Division();
            case "SolutionDegree": return new Degree();
            case "DegreeFraction": return new DegreeFraction();
            case "SolutionLog": return new Log();
            default:
                throw new Exception("Неизвестная операция");
        }
    }
    }

}
