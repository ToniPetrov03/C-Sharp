using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.HextoDecimal
{
    class HextoDecimal
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            long dec = 0;

            for (int i = 0; i < hex.Length; i++)
            {
                long number = 0;
                switch (hex[hex.Length - i - 1])
                {
                    case 'A': number = 10; break;
                    case 'B': number = 11; break;
                    case 'C': number = 12; break;
                    case 'D': number = 13; break;
                    case 'E': number = 14; break;
                    case 'F': number = 15; break;
                    default: number = hex[hex.Length - i - 1] - '0'; break;
                }
                dec += number * (long)Math.Pow(16, i);
            }
            Console.WriteLine(dec);
        }
    }
}
