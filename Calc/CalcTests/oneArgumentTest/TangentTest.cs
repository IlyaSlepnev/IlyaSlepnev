using Calc.oneArgument;
using NUnit.Framework;

namespace CalcTests.oneArgumentTest
{
    [TestFixture]
    public class TangentTest
    {
        [TestCase(0, 0)]
        [TestCase(0, 180)]
        [TestCase(0, 360)]
        public void CalculateTanTest(double firstValue, double expected)
        {
            IOneArgumentCalculator calculator = new Tangent();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);

        }
    }
}