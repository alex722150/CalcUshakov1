using CalcUshakov.TwoArgument;
using NUnit.Framework;

namespace CalcUshakov.Tests.TwoArgument
{
    [TestFixture]
    public class DifDivisionTests
    {
        [TestCase(1, 3, -2.67)]
        [TestCase(2, 3, -0.83)]
        [TestCase(4, 2, 1.5)]
        public void FirstTest(double firstValue, double secondValue, double expected)
        {
            ICalculateTwoArguments calculator = CalculeteTwoFactory.CreateCalculator("difDivision");
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result, 0.01);
        }
    }
}

