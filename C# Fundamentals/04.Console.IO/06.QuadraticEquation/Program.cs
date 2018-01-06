using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double Descriminant = b * b - 4 * a * c;

            double D = Math.Sqrt(Descriminant);

            double x1 = (-b + D) / (2 * a);
            double x2 = (-b - D) / (2 * a);

            if (Descriminant > 0)
            {
                Console.WriteLine("{0:F2}", x2);
                Console.WriteLine("{0:F2}", x1);
            }
            else if (Descriminant < 0)
            {
                Console.WriteLine("no real roots");
            }
            if (Descriminant == 0)
            {
                Console.WriteLine("{0:F2}", x1);
            }
        }
    }
}
