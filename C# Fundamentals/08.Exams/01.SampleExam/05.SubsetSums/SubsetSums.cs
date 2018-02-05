using System;

namespace _05.SubsetSums
{
    class SubsetSums
    {
        private static long sum;
        private static long[] arr;
        private static int result;
        private static long[] generatedArr;
        private static int n;

        static void Main(string[] args)
        {
            sum = long.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            arr = new long[n];
            generatedArr = new long[n];
            result = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = long.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] + arr[j] == sum)
                    {
                        result++;
                    }
                    else
                    {

                    }
                }
            }
            Console.WriteLine(result);
        }

        private static void Brutforce(int index)
        {
            if (index == n)
            {
                return;
            }
            if (Sum(generatedArr) == sum)
            {
                result++;
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    generatedArr[index] = arr[i];
                    Brutforce(index + 1);
                }
            }
        }

        private static long Sum(long[] a)
        {
            long s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                s += a[i];
            }
            return s;
        }
    }
}
