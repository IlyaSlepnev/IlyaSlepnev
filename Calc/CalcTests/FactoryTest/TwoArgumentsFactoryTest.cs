using System;
using Calc.twoArguments;
using NUnit.Framework;

namespace CalcTests.FactoryTest
{
    public class TwoArgumentsFactoryTest
    {
        [TestCase("SolutionPlus", typeof(Plus))]
        [TestCase("SolutionMinus", typeof(Minus))]
        [TestCase("SolutionMulti", typeof(Multiplication))]
        [TestCase("SolutionDiv", typeof(Division))]
        [TestCase("SolutionDegree", typeof(Degree))]
        [TestCase("DegreeFraction", typeof(DegreeFraction))]
        [TestCase("SolutionLog", typeof(Log))]

        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);

        }
    }

}