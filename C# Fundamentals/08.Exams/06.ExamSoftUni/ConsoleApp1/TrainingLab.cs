using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            w *= 100;
            h *= 100;
            int a = (int)w;
            int b = (int)h;

            Console.WriteLine(((b-100)/70)*(a/120)-3);
        }
    }
}
