﻿using Calc.twoArguments;
using NUnit.Framework;

namespace CalcTests.twoArgumentsTest
{
    [TestFixture]
    public class DegreeTest
    {
        [TestCase(5, 2, 25)]
        [TestCase(10, 2, 100)]
        [TestCase(15, 2, 225)]
        public void CalculateDegreeFractionTest(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = new Degree();
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);

        }
    }
}