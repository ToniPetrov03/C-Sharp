using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool exist = false; 
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] == a)
                {
                    exist = true;
                    Console.WriteLine(i);
                    break;
                }
            }
            if (!exist)
            {
                Console.WriteLine(-1);
            }
        }
    }
}
