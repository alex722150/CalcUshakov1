using System;

namespace CalcUshakov.OneArgument
{
    public class Tan : ICalculateOneArgument
    {
        public double Calculate(double argument)
        {
            return Math.Tan(argument);
        }
    }
}
