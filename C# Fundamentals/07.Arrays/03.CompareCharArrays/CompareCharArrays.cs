using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            bool isSame = true;
            for (int i = 0; i < Math.Min(a.Length, b.Length); i++)
            {
                if (a[i] > b[i])
                {
                    isSame = false;
                    Console.WriteLine(">");
                    break;
                }
                else if (a[i] < b[i])
                {
                    isSame = false;
                    Console.WriteLine("<");
                    break;
                }
                else
                {
                    continue;
                }

            }
            if (isSame)
            {
                if (a.Length>b.Length)
                {
                    Console.WriteLine(">");
                }
                else if (a.Length < b.Length)
                {
                    Console.WriteLine("<");
                }
                else
                {
                    Console.WriteLine("=");
                }
                
            }
        }
    }
}
