namespace CalcUshakov.TwoArgument
{
    public class AmountCube : ICalculateTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument * firstArgument * firstArgument) + (secondArgument * secondArgument * secondArgument);
        }
    }
}
