using System;
using System.Numerics;

namespace _08.CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            BigInteger result1 = 1;
            BigInteger result2 = 1;

            for (BigInteger i = 1; i <= 2 * n; i++)
            {
                result *= i;
            }
            for (BigInteger i = 1; i <= n + 1; i++)
            {
                result1 *= i;
            }
            for (BigInteger i = 1; i <= n; i++)
            {
                result2 *= i;
            }

            Console.WriteLine(result / (result1 * result2));
        }
    }
}
