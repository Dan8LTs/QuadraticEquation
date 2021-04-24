using System;

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
            if (discriminant > 0)
            {
                double x1 = (-1 * b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-1 * b - Math.Sqrt(discriminant)) / (2 * a);
                return $"x1 = {x1}; x2 = {x2}";
            }
            else if (discriminant == 0)
            {
                double x = (-1 * b) / (2 * a);
                return $"x = {x}";
            }
            return "No solutions";
        }
    }
}
