using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.OddNumber
{
    class OddNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<long, int> dict = new Dictionary<long, int>();

            for (int i = 0; i < n; i++)
            {
                long number = long.Parse(Console.ReadLine());
                if (!dict.ContainsKey(number))
                {
                    dict.Add(number, 0);
                }
                dict[number]++;
            }

            foreach (var kv in dict)
            {
                if (kv.Value % 2 == 1)
                {
                    var myKey = dict.FirstOrDefault(x => x.Value == kv.Value).Key;
                    Console.WriteLine(myKey);
                    break;
                }
            }
        }
    }
}
