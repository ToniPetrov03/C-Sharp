using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.GCD
{
    class GCD
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int a = input[0];
            int b = input[1];
            int x = 0;
            int n = 0;

            if (a < b)
            {
                n = a;
            }
            else
            {
                n = b;
            }

            for (int i = 1; i <= n; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    x = i;
                }
            }
            Console.WriteLine(x);
        }
    }
}
