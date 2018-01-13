using System;

namespace _16.TrailingZeroinN_
{
    class TrailingZeroinN
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double a = 0;
            for (int i = 5; n / i > 1; i *= 5)
            {
                a += Math.Floor(n / i);
            }
            Console.WriteLine(a);
        }
    }
}
