using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PrintDeck
{
    class PrintDeck
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>
            {
                { "2", 2 },
                { "3", 3 },
                { "4", 4 },
                { "5", 5 },
                { "6", 6 },
                { "7", 7 },
                { "8", 8 },
                { "9", 9 },
                { "10", 10 },
                { "J", 11 },
                { "Q", 12 },
                { "K", 13 },
                { "A", 14 }
            };
            string card = Console.ReadLine();

            for (int i = 2; i <= dict[card]; i++)
            {
                string a = dict.FirstOrDefault(x => x.Value == i).Key;
                Console.WriteLine(a + " of spades, " + a + " of clubs, " + a + " of hearts, " + a + " of diamonds");
            }
        }
    }
}
