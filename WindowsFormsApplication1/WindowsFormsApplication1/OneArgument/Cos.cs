using System;

namespace CalcUshakov.OneArgument
{
    public class Cos : ICalculateOneArgument
    {
        public double Calculate(double argument)
        {
            return Math.Cos(argument);
        }
    }
}
