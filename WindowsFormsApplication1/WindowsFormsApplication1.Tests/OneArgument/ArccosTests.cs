using System;
using CalcUshakov.OneArgument;
using NUnit.Framework;

namespace CalcUshakov.Tests.OneArgument
{
    [TestFixture]
    public class ArccosTests
    {
        [TestCase(0, 1.57)]
        [TestCase(1, 0)]
        [TestCase(-1, 3.14)]
        public void FirstTest(double value, double expected)
        {
            ICalculateOneArgument calculator = CalculateOneFactory.CreateCalculator("Arccos");
            double result = calculator.Calculate(value);
            Assert.AreEqual(expected, result, 0.01);
        }
        [Test]
        public void ArccosExceptionTest()
        {
            ICalculateOneArgument calculator = CalculateOneFactory.CreateCalculator("Arccos");
            Assert.Throws<Exception>(() => calculator.Calculate(2));
        }
    }
}
