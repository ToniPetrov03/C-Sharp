using System;
namespace _03.Trapezoid
{
    class Trapezoid
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numberOfLeftDots = n - 1;
            int numberOfRightDots = 0;
            int numberOfDots = n - 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write('.');
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine();

            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string('.', numberOfLeftDots));
                Console.Write('*');
                Console.Write(new string('.', numberOfRightDots));
                Console.Write(new string('.', numberOfDots));
                Console.Write('*');
                numberOfLeftDots--;
                numberOfRightDots++;
                Console.WriteLine();
            }
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write('*');
            }
        }
    }
}
