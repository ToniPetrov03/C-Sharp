using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Divide7and5
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            if (input % 5 == 0 && input % 7 == 0)
            {
                Console.WriteLine("true " + input);
            }
            else
            {
                Console.WriteLine("false " + input);
            }
        }
    }
}
