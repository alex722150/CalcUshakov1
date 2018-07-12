using CalcUshakov.TwoArgument;
using NUnit.Framework;

namespace CalcUshakov.Tests.TwoArgument
{
    [TestFixture]
    public class SquareOfAmountTests
    {
        [TestCase(1, 3, 16)]
        [TestCase(2, 3, 25)]
        [TestCase(4, 2, 36)]
        public void FirstTest(double firstValue, double secondValue, double expected)
        {
            ICalculateTwoArguments calculator = CalculeteTwoFactory.CreateCalculator("squareOfAmount");
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result, 0.01);
        }
    }
}


