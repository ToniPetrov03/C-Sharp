﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            Console.Write("{0:F2} ", 2 * Math.PI * r);
            Console.WriteLine("{0:F2}", Math.PI * r * r);
        }
    }
}
