using Calc.oneArgument;
using NUnit.Framework;

namespace CalcTests.oneArgumentTest
{
    [TestFixture]
    public class CosTest
    {
        [TestCase(0, 1)]
        [TestCase(90, 0)]
        [TestCase(180, -1)]
        public void CalculateCosTest(double firstValue, double expected)
        {
            IOneArgumentCalculator calculator = new Сosine();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);

        }
    }
}