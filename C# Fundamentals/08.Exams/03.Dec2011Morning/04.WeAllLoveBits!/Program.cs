using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WeAllLoveBits_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine()); ;
                string bits = Convert.ToString(number, 2);
                char[] reverse = bits.ToCharArray();
                Array.Reverse(reverse);
                int reversed = Convert.ToInt32(new string(reverse), 2);

                char[] invert = bits.ToCharArray();

                for (int j = 0; j < invert.Length; j++)
                {
                    if (invert[j] == '1')
                    {
                        invert[j] = '0';
                    }
                    else
                    {
                        invert[j] = '1';
                    }
                }
                int inverted = Convert.ToInt32(new string(invert), 2);


                Console.WriteLine((number ^ inverted) & reversed);
            }
        }
    }
}
