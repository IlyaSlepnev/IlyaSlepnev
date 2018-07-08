using Calc.twoArguments;
using NUnit.Framework;

namespace CalcTests.twoArgumentsTest
{
    [TestFixture]
    public class LogTest
    {
        [TestCase(2, 8, 3)]
        [TestCase(7, 49, 2)]
        [TestCase(3, 27, 3)]
        public void CalculateLogTest(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = new Log();
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);

        }
    }
}