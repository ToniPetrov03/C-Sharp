using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            int a = NashParse(Console.ReadLine());
            Console.WriteLine(a);
            int b = NashParse(Console.ReadLine());
            int c = NashParse(Console.ReadLine());
            int d = NashParse(Console.ReadLine());
            int e = NashParse(Console.ReadLine());

            int smallest = int.MaxValue;

            int abc = LCM(a, LCM(b, c));
            int abd = LCM(a, LCM(b, d));
            int abe = LCM(a, LCM(b, e));
            int acd = LCM(a, LCM(c, d));
            int ace = LCM(a, LCM(c, e));
            int ade = LCM(a, LCM(d, e));
            int bcd = LCM(b, LCM(c, d));
            int bce = LCM(b, LCM(c, e));
            int bde = LCM(b, LCM(d, e));
            int cde = LCM(c, LCM(d, e));

            if (abc < smallest)
                smallest = abc;

            if (abd < smallest)
                smallest = abd;

            if (abe < smallest)
                smallest = abe;

            if (acd < smallest)
                smallest = acd;

            if (ace < smallest)
                smallest = ace;

            if (ade < smallest)
                smallest = ade;

            if (bcd < smallest)
                smallest = bcd;

            if (bce < smallest)
                smallest = bce;

            if (bde < smallest)
                smallest = bde;

            if (cde < smallest)
                smallest = cde;

            //Console.WriteLine(smallest);
        }

        private static int TehenParse(string a)
        {
            return int.Parse(a);
        }

        private static int NashParse(string a)
        {
            int number = 0;
            int multiple = 1;
            for (int i = 0; i < a.Length; i++)
            {
                int digit = a[a.Length - 1 - i] - '0';
                number += digit * multiple;
                multiple *= 10;
            }
            return number;
        }
        

        private static int LCM(int a, int b)
        {
            int num1, num2;
            if (a > b)
            {
                num1 = a; num2 = b;
            }
            else
            {
                num1 = b; num2 = a;
            }

            for (int i = 1; i < num2; i++)
            {
                if ((num1 * i) % num2 == 0)
                {
                    return i * num1;
                }
            }
            return num1 * num2;
        }
    }
}
