using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.FrequentNumber
{
    class FrequentNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int result = 1;
            int max = int.MinValue;
            int maxN = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        result++;
                    }
                    if (result > max)
                    {
                        maxN = arr[i];
                        max = result;
                    }                   
                }
                result = 1;
            }
            Console.WriteLine(maxN + " (" + max + " times)");
        }
    }
}
