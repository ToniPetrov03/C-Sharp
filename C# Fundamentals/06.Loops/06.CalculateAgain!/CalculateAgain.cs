﻿using System;
using System.Numerics;

namespace _06.CalculateAgain_
{
    class CalculateAgain
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            for (int i = k + 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}
