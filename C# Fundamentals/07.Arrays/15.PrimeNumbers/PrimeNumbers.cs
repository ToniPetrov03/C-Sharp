using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            bool[] notPrimes = new bool[n + 1];
            ulong max = 0;
            for (ulong i = 2; i <= n; i++)
            {
                if (!notPrimes[i])
                {
                    max = i;
                    for (ulong j = i * i; j <= n; j += i)
                    {
                        notPrimes[j] = true;
                    }
                }
            }
            Console.WriteLine(max);
        }
    }
}
