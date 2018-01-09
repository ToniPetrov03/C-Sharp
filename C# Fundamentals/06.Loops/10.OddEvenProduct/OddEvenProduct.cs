using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.OddEvenProduct
{
    class OddEvenProduct
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int evenProduct = 1;
            int oddProduct = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    evenProduct *= numbers[i - 1];
                }
                else
                {
                    oddProduct *= numbers[i - 1];
                }
            }
            if (evenProduct==oddProduct)
            {
                Console.WriteLine("yes "+ evenProduct);
            }
            else
            {
                Console.WriteLine("no " + oddProduct + " " + evenProduct);
            }
        }
    }
}
