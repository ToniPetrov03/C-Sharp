using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IntDoubleAndString
{
    class IntDoubleAndString
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();

            if (a == "integer")
            {
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(b + 1);
            }
            else if (a == "real")
            {
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", b + 1);
            }
            else if (a == "text")
            {
                string b = Console.ReadLine();
                Console.WriteLine(b + "*");
            }
        }
    }
}
