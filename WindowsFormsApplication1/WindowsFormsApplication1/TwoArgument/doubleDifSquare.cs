namespace CalcUshakov.TwoArgument
{
    public class DoubleDifSquare : ICalculateTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument * firstArgument) - (secondArgument * secondArgument);
        }
    }
}
