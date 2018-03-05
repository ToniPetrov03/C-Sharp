using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SandGlass
{
    class SandGlass
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numberOfDots = 1;
            int numberOfAsterisk = n - 2;

            Console.WriteLine(new string('*', n));

            for (int i = numberOfAsterisk; i > 0; i -= 2)
            {
                Console.Write(new string('.', numberOfDots));
                Console.Write(new string('*', numberOfAsterisk));
                Console.WriteLine(new string('.', numberOfDots));

                numberOfDots++;
                numberOfAsterisk -= 2;
            }
            numberOfDots = (n - 3) / 2;
            numberOfAsterisk = 3;

            for (int i = numberOfDots; i > 0; i--)
            {
                Console.Write(new string('.', numberOfDots));
                Console.Write(new string('*', numberOfAsterisk));
                Console.WriteLine(new string('.', numberOfDots));

                numberOfDots--;
                numberOfAsterisk += 2;
            }

            Console.WriteLine(new string('*', n));
        }
    }
}
