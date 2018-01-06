using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MMSAofNNumbers
{
    class MMSAofNNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double min = double.MaxValue;
            double max = double.MinValue;
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                double a = double.Parse(Console.ReadLine());
                if (a < min)
                    min = a;
                if (a > max)
                    max = a;
                sum += a;
            }
            Console.WriteLine("min={0:F2}", min);
            Console.WriteLine("max={0:F2}", max);
            Console.WriteLine("sum={0:F2}", sum);
            Console.WriteLine("avg={0:F2}", sum/n);
        }
    }
}
