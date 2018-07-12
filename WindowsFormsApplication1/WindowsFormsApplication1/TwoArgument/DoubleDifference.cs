namespace CalcUshakov.TwoArgument
{
    public  class DoubleDifference : ICalculateTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return 2 * (firstArgument - secondArgument);
        }
    }
}
