using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                sum = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    sum += arr[j];
                    if (sum > max)
                    {
                        max = sum;
                    }
                }
                sum = 0;
            }
            Console.WriteLine(max);
        }
    }
}
