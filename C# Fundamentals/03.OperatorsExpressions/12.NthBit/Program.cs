using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.NthBit
{
    class Program
    {
        static void Main(string[] args)
        {
            long x = long.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(x>>n&1);
        }
    }
}
