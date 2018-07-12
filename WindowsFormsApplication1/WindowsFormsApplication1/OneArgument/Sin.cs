using System;

namespace CalcUshakov.OneArgument
{
    public class Sin : ICalculateOneArgument
    {
        public double Calculate(double argument)
        {
            return Math.Sin(argument);
        }
    }
}
