using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FirTree
{
    class FirTree
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numberOfLeftDots = n - 2;
            int numberOfRightAsterisk = 1;
            int numberOfLeftAsterisk = 0;

            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string('.', numberOfLeftDots));
                Console.Write(new string('*', numberOfRightAsterisk));
                Console.Write(new string('*', numberOfLeftAsterisk));
                Console.WriteLine(new string('.', numberOfLeftDots));

                numberOfLeftDots--;
                numberOfRightAsterisk++;
                numberOfLeftAsterisk++;
            }
            Console.Write(new string('.', n - 2));
            Console.Write('*');
            Console.WriteLine(new string('.', n - 2));
        }
    }
}
