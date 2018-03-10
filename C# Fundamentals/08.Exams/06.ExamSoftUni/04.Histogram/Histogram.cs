using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;


            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine());
                if (m < 200)
                {
                    p1++;
                }
                else if (m > 199 && m < 400)
                {
                    p2++;
                }
                else if (m > 399 && m < 600)
                {
                    p3++;
                }
                else if (m > 599 && m < 800)
                {
                    p4++;
                }
                else if (m > 799)
                {
                    p5++;
                }
            }
                Console.WriteLine("{0:F2}", p1 / n * 100 + "%");
                Console.WriteLine("{0:F2}", p2 / n * 100 + "%");
                Console.WriteLine("{0:F2}", p3 / n * 100 + "%");
                Console.WriteLine("{0:F2}", p4 / n * 100 + "%");
                Console.WriteLine("{0:F2}", p5 / n * 100 + "%");
        }
    }
}
