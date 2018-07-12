using System;
using CalcUshakov.OneArgument;
using NUnit.Framework;

namespace CalcUshakov.Tests.OneArgument
{
    [TestFixture]
    public class ArcsinTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1.57)]
        [TestCase(-1, -1.57)]
        public void FirstTest(double value, double expected)
        {
            ICalculateOneArgument calculator = CalculateOneFactory.CreateCalculator("Arcsin");
            double result = calculator.Calculate(value);
            Assert.AreEqual(expected, result, 0.01);
        }
        [Test]
        public void ArcsinExceptionTest()
        {
            ICalculateOneArgument calculator = CalculateOneFactory.CreateCalculator("Arcsin");
            Assert.Throws<Exception>(() => calculator.Calculate(2));
        }
    }
}
