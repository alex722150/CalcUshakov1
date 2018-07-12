namespace CalcUshakov.OneArgument
{
    public class Square : ICalculateOneArgument
    {
        public double Calculate(double argument)
        {
            return argument * argument;
        }
    }
}
