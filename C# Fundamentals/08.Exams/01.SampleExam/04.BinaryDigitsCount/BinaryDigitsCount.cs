using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BinaryDigitsCount
{
    class BinaryDigitsCount
    {
        static void Main(string[] args)
        {
            int bit = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                uint currentNumber = uint.Parse(Console.ReadLine());
                int numberOfBit = 0;
                while (currentNumber != 0)
                {
                    if (currentNumber % 2 == bit)
                    {
                        numberOfBit++;
                    }
                    currentNumber /= 2;
                }
                Console.WriteLine(numberOfBit);
            }
        }
    }
}
