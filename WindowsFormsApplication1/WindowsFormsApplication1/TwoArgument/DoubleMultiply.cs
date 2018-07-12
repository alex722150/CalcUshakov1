namespace CalcUshakov.TwoArgument
{
    public class DoubleMultiply : ICalculateTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return 2 * (firstArgument * secondArgument);
        }
    }
}
