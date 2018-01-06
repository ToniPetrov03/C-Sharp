using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.PrimeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            long x = long.Parse(Console.ReadLine());
            bool isPrime = true;
            for (long i = 2; i < Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (!isPrime || x <= 1)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
        }
    }
}
