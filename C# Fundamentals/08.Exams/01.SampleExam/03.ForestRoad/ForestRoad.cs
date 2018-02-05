using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ForestRoad
{
    class ForestRoad
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numberOfLeftDots = 0;
            int numberOfRightDots = n - 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', numberOfLeftDots));
                Console.Write('*');
                Console.WriteLine(new string('.', numberOfRightDots));
                numberOfLeftDots++;
                numberOfRightDots--;
            }
            numberOfLeftDots-=2;
            numberOfRightDots+=2;
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string('.', numberOfLeftDots));
                Console.Write('*');
                Console.WriteLine(new string('.', numberOfRightDots));
                numberOfLeftDots--;
                numberOfRightDots++;
            }
        }
    }
}
