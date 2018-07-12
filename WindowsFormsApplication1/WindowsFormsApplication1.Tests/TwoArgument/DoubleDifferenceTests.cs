using CalcUshakov.TwoArgument;
using NUnit.Framework;

namespace CalcUshakov.Tests.TwoArgument
{
    [TestFixture]
    public class DoubleDifferenceTests
    {
        [TestCase(1, 1, 0)]
        [TestCase(2, 2, 0)]
        [TestCase(3, 3, 0)]
        public void FirstTest(double firstValue, double secondValue, double expected)
        {
            ICalculateTwoArguments calculator = CalculeteTwoFactory.CreateCalculator("doubleDifference");
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result, 0.01);
        }
    }
}
