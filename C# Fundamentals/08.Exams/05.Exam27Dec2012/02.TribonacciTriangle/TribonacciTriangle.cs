using System;
using System.Numerics;

namespace _02.TribonacciTriangle
{
    class TribonacciTriangle
    {
        static void Main(string[] args)
        {
            BigInteger a = BigInteger.Parse(Console.ReadLine());
            BigInteger b = BigInteger.Parse(Console.ReadLine());
            BigInteger c = BigInteger.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(a);
            Console.WriteLine(b + " " + c);

            for (int i = 3; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    BigInteger x = a;
                    a = b;
                    b = c;
                    c = x + a + b;
                    Console.Write(c + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
