using System;

namespace _01.Decimal_to_Binary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b;
            string result = string.Empty;

            while (a > 0)
            {
                b = a % 2;
                a /= 2;
                result = b.ToString() + result;
            }
            Console.WriteLine(result);
        }
    }
}