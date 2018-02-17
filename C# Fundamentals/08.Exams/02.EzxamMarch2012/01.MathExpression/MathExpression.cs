using System;

namespace _01.MathExpression
{
    class MathExpression
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            double P = double.Parse(Console.ReadLine());
            int x = (int)M;

            Console.WriteLine("{0:F6}", (N * N + 1 / (M * P) + 1337) / (N - 128.523123123 * P) + Math.Sin(x % 180));
        }
    }
}
