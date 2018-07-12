using System;
using CalcUshakov.TwoArgument;
using NUnit.Framework;

namespace CalcUshakov.Tests.FabricTests
{
    class TwoArgumentFabricTests
    {
        [TestCase("DoublAmount", typeof(DoublAmount))]
        [TestCase("doubleDifference", typeof(DoubleDifference))]
        public void FirstTest(string name, Type type)
        {
            var calculator = CalculeteTwoFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
