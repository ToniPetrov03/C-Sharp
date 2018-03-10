using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DrawFort
{
    class DrawFort
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write("/" + new string('^', n / 2) + '\\');
            if (n > 4)
            {
                Console.Write(new string('_', n * 2 - ((n/2)*2 + 4)));
            }
            Console.WriteLine("/" + new string('^', n / 2) + '\\');

            if (n >= 3 && n <= 4)
            {
                for (int i = 2; i < n; i++)
                {
                    Console.Write("|");
                    Console.WriteLine(new string(' ', n * 2 - 2) + "|");
                }
            }
            if (n > 4)
            {
                for (int i = 3; i < n; i++)
                {
                    Console.Write("|");
                    Console.WriteLine(new string(' ', n * 2 - 2) + "|");
                }
                Console.WriteLine("|" + new string(' ', n / 2 + 1) + new string('_', n * 2 - ((n / 2) * 2 + 4)) + new string(' ', n / 2 + 1) + "|");
            }
            Console.Write('\\' + new string('_', n /2) + "/");
            if (n > 4)
            {
                Console.Write(new string(' ', n * 2 - ((n / 2) * 2 + 4)));
            }
            Console.WriteLine('\\' + new string('_', n /2) + "/");
        }
    }
}
