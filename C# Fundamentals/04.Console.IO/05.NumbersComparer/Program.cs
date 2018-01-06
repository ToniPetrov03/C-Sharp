using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.NumbersComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());

            if (x>a)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(a);
            }
        }
    }
}
