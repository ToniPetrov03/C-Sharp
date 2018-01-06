using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PointCircleRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double distance = Math.Sqrt((x - 1) * (x - 1) + (y - 1) * (y - 1));
            if (distance <= 1.5)
            {
                Console.Write("inside circle ");
            }
            else
            {
                Console.Write("outside circle ");
            }

            if (x>=-1 && x<=5 && y>=-1 && y<=1)
            {
                Console.WriteLine("inside rectangle");
            }
            else
            {
                Console.WriteLine("outside rectangle");
            }
        }   
    }
}
