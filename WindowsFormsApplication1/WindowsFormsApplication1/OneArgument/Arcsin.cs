using System;

namespace CalcUshakov.OneArgument
{
        public class Arcsin : ICalculateOneArgument
        {
            public double Calculate(double argument)
            {
                if (argument < -1 || argument > 1)
                {
                    throw new Exception("не существует");
                }
            return Math.Asin(argument);
            }
        }
    
}
