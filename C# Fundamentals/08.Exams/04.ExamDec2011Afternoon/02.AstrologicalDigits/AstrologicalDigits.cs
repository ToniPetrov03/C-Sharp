using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AstrologicalDigits
{
    class AstrologicalDigits
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 11;
            

            while (sum > 10)
            {
                sum = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    switch (input[i])
                    {
                        case '1': sum += 1; break;
                        case '2': sum += 2; break;
                        case '3': sum += 3; break;
                        case '4': sum += 4; break;
                        case '5': sum += 5; break;
                        case '6': sum += 6; break;
                        case '7': sum += 7; break;
                        case '8': sum += 8; break;
                        case '9': sum += 9; break;
                        default: break;
                    }
                }
                input = sum.ToString();
            }
            Console.WriteLine(sum);
        }
    }
}
