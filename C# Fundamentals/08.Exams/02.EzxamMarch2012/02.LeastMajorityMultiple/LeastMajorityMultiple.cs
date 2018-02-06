using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LeastMajorityMultiple
{
    class LeastMajorityMultiple
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int three = 0;

            for (int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i < 100000; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i >= arr[j] && i % arr[j] == 0)
                    {
                        three++;
                        if (three >= 3)
                        {
                            Console.WriteLine(i);
                            Environment.Exit(0);
                        }
                    }
                }
                three = 0;
            }
        }
    }
}
