using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PlayCard
{
    class PlayCard
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();

            if (a == "J" || a == "Q" || a == "K" || a == "A" || int.Parse(a) > 1 && int.Parse(a) < 11)
            {
                Console.WriteLine("yes " + a);
            }
            else
            {
                Console.WriteLine("no " + a);
            }
        }
    }
}
