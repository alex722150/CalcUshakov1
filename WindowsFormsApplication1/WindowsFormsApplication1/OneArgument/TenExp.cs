using System;

namespace CalcUshakov.OneArgument
{
    public class TenExp : ICalculateOneArgument
    {
        public double Calculate(double argument)
        {
            return Math.Pow(10, argument);
        }
    }
}
