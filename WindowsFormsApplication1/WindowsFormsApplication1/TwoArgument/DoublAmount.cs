namespace CalcUshakov.TwoArgument
{
    public class DoublAmount : ICalculateTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return 2*(firstArgument + secondArgument);
        }
    }
}
