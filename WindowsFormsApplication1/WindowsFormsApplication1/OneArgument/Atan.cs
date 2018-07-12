using System;

namespace CalcUshakov.OneArgument
{
    public class Atan : ICalculateOneArgument
    {
        public double Calculate(double argument)
        {
            return Math.Atan(argument);
        }
    }
}
