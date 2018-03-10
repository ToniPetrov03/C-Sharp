using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            if (n < 20 && time == "day")
            {
                Console.WriteLine(0.7 + n * 0.79);
            }
            else if (n < 20 && time == "night")
            {
                Console.WriteLine(0.7 + n * 0.9);
            }
            else if (n >= 20 && n < 100)
            {
                Console.WriteLine(n * 0.09);
            }
            else if (n >= 100)
            {
                Console.WriteLine(n * 0.06);
            }
        }
    }
}
