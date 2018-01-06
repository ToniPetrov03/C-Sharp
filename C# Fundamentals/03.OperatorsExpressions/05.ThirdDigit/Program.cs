using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ThirdDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int hardMath = (x / 100) % 10;
            if (hardMath==7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false " + hardMath);
            }
        }
    }
}
