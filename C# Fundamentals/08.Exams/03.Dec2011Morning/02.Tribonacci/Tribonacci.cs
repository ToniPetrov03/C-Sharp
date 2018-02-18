using System;
using System.Numerics;

namespace _02.Tribonacci
{
    class Tribonacci
    {
        static void Main(string[] args)
        {
            BigInteger a = BigInteger.Parse(Console.ReadLine());
            BigInteger b = BigInteger.Parse(Console.ReadLine());
            BigInteger c = BigInteger.Parse(Console.ReadLine());
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            if (n==1)
            {
                Console.WriteLine(a);
            }
            else if (n==2)
            {
                Console.WriteLine(b);
            }
            else if (n==3)
            {
                Console.WriteLine(c);
            }
            else if (n>3)
            {
                for (int i = 3; i < n; i++)
                {
                    BigInteger x = a;
                    a = b;
                    b = c;
                    c = x + a + b;
                }
                Console.WriteLine(c);
            }
        }
    }
}
