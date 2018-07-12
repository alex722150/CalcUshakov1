using System;

namespace CalcUshakov.OneArgument
{
    public class Ctan : ICalculateOneArgument
    {
        public double Calculate(double argument)
        {
            return 1f / Math.Tan(argument);
        }
    }
}
