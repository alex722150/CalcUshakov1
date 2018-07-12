namespace CalcUshakov.TwoArgument
{
    public class Multiplication : ICalculateTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }
    }
}
