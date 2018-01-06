using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.BitExchange
{
    class Exchange
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());

            uint mask3 = (n & (7 << 3)) >> 3;
            uint mask24 = (n & (7 << 24)) >> 24;

            uint a = mask3 ^ mask24;

            n = n ^ a << 3;
            n = n ^ a << 24;

            Console.WriteLine(n);
        }
    }
}