using System;

namespace CalcUshakov.OneArgument
{
    public class Arccos : ICalculateOneArgument
    {
        public double Calculate(double argument)
        {
            if (argument <-1 || argument > 1)
            {
                throw new Exception("не существует");
            }
            return Math.Acos(argument);
        }
    }
}
