using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MaximalSequence
{
    class MaximalSequence
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int result = 0;
            int repeated = 1;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i]==arr[i-1])
                {
                    repeated++;
                }
                else
                {
                    if (repeated > result)
                    {
                        result = repeated;
                    }
                    repeated = 1;
                }
            }
            Console.WriteLine(result);
        }
    }
}
