using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            if (a > 0 && a < 4)
            {
                Console.WriteLine(a * 10);
            }
            if (a > 3 && a < 7)
            {
                Console.WriteLine(a * 100);
            }
            if (a > 6 && a < 10)
            {
                Console.WriteLine(a * 1000);
            }
            if (a < 1 || a > 9)
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}
