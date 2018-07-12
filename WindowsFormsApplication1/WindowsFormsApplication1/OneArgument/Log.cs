using System;

namespace CalcUshakov.OneArgument
{
    public class Log : ICalculateOneArgument
    {
        public double Calculate(double argument)
        {
            if (argument <= 0)
            {
                throw new Exception("не существует");
            }
            return Math.Log(argument);
        }
    }
}
