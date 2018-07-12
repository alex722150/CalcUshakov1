using System;

namespace CalcUshakov.TwoArgument
{
    public static class CalculeteTwoFactory
    {
        public static ICalculateTwoArguments CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "buttonAmount":
                    return new Amount();
                case "buttonDifference":
                    return new Subtraction();
                case "buttonMultiply":
                    return new Multiplication();
                case "buttonDivision":
                    return new Division();
                case "DoublAmount":
                    return new DoublAmount();
                case "doubleDifference":
                    return new DoubleDifference();
                case "doubleMultiply":
                    return new DoubleMultiply();
                case "doubleDivision":
                    return new DoubleDivision();
                case "amountSquare":
                    return new AmountSquare();
                case "doubleDifSquare":
                    return new DoubleDifSquare();
                case "difDivision":
                    return new DifDivision();
                case "amountCube":
                    return new AmountCube();
                case "difCube":
                    return new DifCube();
                case "squareOfAmount":
                    return new SquareOfAmount();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
