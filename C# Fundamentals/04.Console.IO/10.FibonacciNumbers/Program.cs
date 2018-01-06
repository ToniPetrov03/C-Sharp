using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long a = 0;
            long b = 1;
            if (n==1)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.Write("0, 1");

                for (int i = 2; i < n; i++)
                {
                    long c = a;
                    a = b;
                    b = c + a;
                    Console.Write(", " + b);
                }
                Console.WriteLine();
            }  
        }
    }
}
