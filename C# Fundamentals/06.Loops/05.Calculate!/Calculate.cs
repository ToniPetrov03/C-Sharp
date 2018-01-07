using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Calculate_
{
    class Calculate
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double sum = 0;
            double exponential = 1;
            for (int i = 0; i <= n; i++)
            {
                double factoriel = 1;
                for (int j = 2; j <= i; j++)
                {
                    factoriel *= j;
                }
                sum += (factoriel / exponential);
                exponential = exponential * x;
            }
            Console.WriteLine("{0:F5}", (sum));
        }
    }
}
