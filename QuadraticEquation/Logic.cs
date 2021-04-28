using System;
using System.Linq;

namespace QuadraticEquation
{
    public class Logic
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public string D { get; set; }
        public Logic(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
            D = Discriminant(A, B, C);
        }
        public static string Discriminant(double a, double b, double c)
        {
            double discriminant;
            discriminant = b * b - 4 * a * c;
            char symbol = '=';
            if (discriminant > 0)
            {
                double x1 = (-1 * b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-1 * b - Math.Sqrt(discriminant)) / (2 * a);
                if(x1 != Math.Round(x1, 2))
                {
                    symbol = '≈';
                }
                return $"x1 {symbol} {Math.Round(x1, 2)}; x2 {symbol} {Math.Round(x2, 2)}";
            }
            else if (discriminant == 0)
            {
                double x = (-1 * b) / (2 * a);
                if (x != Math.Round(x, 2))
                {
                    symbol = '≈';
                }
                return $"x {symbol} {Math.Round(x, 2)}";
            }
            return "No solutions";
        }
    }
}
