using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MissCat2011
{
    class MissCat2011
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] cats = new int[10];
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int vote = int.Parse(Console.ReadLine());
                cats[vote - 1]++;
            }

            int maxVotes = int.MinValue;
            int maxCat = 0;
            for (int i = 0; i < 10; i++)
            {
                if (cats[i] > maxVotes)
                {
                    maxVotes = cats[i];
                    maxCat = i + 1;
                }
            }
            Console.WriteLine(maxCat);
        }
    }
}
