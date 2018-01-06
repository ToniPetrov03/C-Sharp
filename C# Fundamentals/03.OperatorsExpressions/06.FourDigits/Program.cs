using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FourDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            int d = x % 10;
            int c = (x / 10) % 10;
            int b = (x / 100) % 10;
            int a = (x / 1000) % 10;

            Console.WriteLine(a + b + c + d);
            Console.WriteLine(d + "" + c + "" + b + "" + a);
            Console.WriteLine(d + "" + a + "" + b + "" + c);
            Console.WriteLine(a + "" + c + "" + b + "" + d);
        }
    }
}
