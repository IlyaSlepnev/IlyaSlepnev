using Calc.oneArgument;
using NUnit.Framework;

namespace CalcTests.oneArgumentTest
{
    [TestFixture]
    public class RadicalTest
    {
        [TestCase(4, 2)]
        [TestCase(16, 4)]
        [TestCase(64, 8)]
        public void CalculateRadicalTest(double firstValue, double expected)
        {
            IOneArgumentCalculator calculator = new Radical();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);

        }
    }
}