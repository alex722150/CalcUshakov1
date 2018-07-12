namespace CalcUshakov.TwoArgument
{
    public class SquareOfAmount : ICalculateTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument * firstArgument) + (2 * secondArgument * firstArgument)+ (secondArgument * secondArgument);
        }
    }
}
