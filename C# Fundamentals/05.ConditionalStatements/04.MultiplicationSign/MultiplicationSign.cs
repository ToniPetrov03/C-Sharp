﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a * b * c > 0)
            {
                Console.WriteLine("+");
            }
            if (a * b * c < 0)
            {
                Console.WriteLine("-");
            }
            if (a * b * c == 0)
            {
                Console.WriteLine(0);
            }
        }
    }
}
