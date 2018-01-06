using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.PrintTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = '!'; i <= '~'; i++)
            {
                Console.Write((char) i);
            }
        }
    }
}
