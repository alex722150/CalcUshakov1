using System;

namespace CalcUshakov.OneArgument
{
    public class CalculateOneFactory
    {
        public static ICalculateOneArgument CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Square":
                    return new Square();
                case "Sin":
                    return new Sin();
                case "TenExp":
                    return new TenExp();
                case "Cos":
                    return new Cos();
                case "Cube":
                    return new Cube();
                case "Tan":
                    return new Tan();
                case "Atan":
                    return new Atan();
                case "Fraction":
                    return new Fraction();
                case "Ctan":
                    return new Ctan();
                case "Arcsin":
                    return new Arcsin();
                case "Arccos":
                    return new Arccos();
                case "Log":
                    return new Log();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}

