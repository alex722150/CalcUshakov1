using CalcUshakov.TwoArgument;
using NUnit.Framework;

namespace CalcUshakov.Tests.TwoArgument
{
    [TestFixture]
    public class DifferenceTests
    {
        [Test]
        public void FirstTest()
        {
            ICalculateTwoArguments calculator = CalculeteTwoFactory.CreateCalculator("buttonDifference");
            double result = calculator.Calculate(6, 5);
            Assert.AreEqual(1, result);
        }
    }
}
