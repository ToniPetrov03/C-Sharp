using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ModifyBit
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong x = ulong.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            byte v = byte.Parse(Console.ReadLine());
            ulong mask = 1;
            if (v == 1)
            {
                Console.WriteLine((mask << n) | x);
            }
            else
            {
                Console.WriteLine(~(mask << n) & x);
            }
        }
    }
}
