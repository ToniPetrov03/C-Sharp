using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TribonacciTriangle
{
    class TribonacciTriangle
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(a);
            Console.WriteLine(b + " " + c);
            int p = 6;
            int t = 3;
            int y = 0;
            int j = 3;
            for (int i = 3; i < p; i++)
            {
                for (; j < p; j++)
                {
                    int x = a;
                    a = b;
                    b = c;
                    c = x + a + b;
                    Console.Write(c + " ");
                }
                Console.WriteLine();
                y++;
                t += y;
                p += t;
                if (t > n)
                {
                    break;
                }
            }
        }
    }
}
