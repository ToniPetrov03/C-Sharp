using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.Write("{0:f2}", width *height);
            Console.Write(" ");
            Console.WriteLine("{0:f2}", 2 *width+2*height);
        }
    }
}
