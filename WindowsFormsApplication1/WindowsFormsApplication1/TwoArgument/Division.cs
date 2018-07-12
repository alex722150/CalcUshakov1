using System;

namespace CalcUshakov.TwoArgument
{
   public class Division : ICalculateTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("деление на 0");
            }
            return firstArgument / secondArgument;
        }
    }
}
