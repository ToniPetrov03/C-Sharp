using System;
using System.Numerics;
namespace _07.Calculate3_
{
    class Calculate3
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            BigInteger result1 = n - k;

            for (int i = k + 1; i <= n; i++)
            {
                result *= i;
            }
            for (int i = 1; i < n - k; i++)
            {
                result1 *= (n - k) - i;
            }
            Console.WriteLine(result / result1);
        }
    }
}
