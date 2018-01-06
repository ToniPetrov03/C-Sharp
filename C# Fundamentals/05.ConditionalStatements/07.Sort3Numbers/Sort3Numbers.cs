using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sort3Numbers
{
    class Sort3Numbers
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a > b && a > c && b >= c)
                Console.WriteLine(a + " " + b + " " + c);

            if (a > b && a > c && c >= b)
                Console.WriteLine(a + " " + c + " " + b);

            if (b > a && b > c && a >= c)
                Console.WriteLine(b + " " + a + " " + c);

            if (b > a && b > c && c >= a)
                Console.WriteLine(b + " " + c + " " + a);

            if (c > a && c > b && a >= b)
                Console.WriteLine(c + " " + a + " " + b);

            if (c > a && c > b && b >= a)
                Console.WriteLine(c + " " + b + " " + a);

            if (a == b && a == c)
                Console.WriteLine(b + " " + a + " " + c);
        }
    }
}
