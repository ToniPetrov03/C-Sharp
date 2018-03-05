using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DancingBits
{
    class DancingBits
    {
        static void Main(string[] args)
        {
            int numberBits = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string sum = "";
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                sum+= Convert.ToString(int.Parse(Console.ReadLine()), 2);
            }
            int repeats = 1;
            for (int i = 0; i < sum.Length - 1; i++)
            {
                if (sum[i] == sum[i+1])
                {
                    repeats++;
                }
                else
                {
                    if (repeats == numberBits)
                    {
                        result++;
                        repeats = 1;
                    }
                }
            }
            if (repeats == numberBits)
            {
                result++;
            }
            Console.WriteLine(result);
        }
    }
}
