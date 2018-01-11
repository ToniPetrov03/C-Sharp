using System;

namespace _13.DecimaltoHex
{
    class DecimaltoHex
    {
        static void Main(string[] args)
        {
            long decimalNumber = long.Parse(Console.ReadLine());
            long remainder;
            string result = string.Empty;

            while (decimalNumber > 0)
            {
                string strRemainder = "";
                remainder = decimalNumber % 16;
                switch (remainder)
                {
                    case 10: strRemainder = "A"; break;
                    case 11: strRemainder = "B"; break;
                    case 12: strRemainder = "C"; break;
                    case 13: strRemainder = "D"; break;
                    case 14: strRemainder = "E"; break;
                    case 15: strRemainder = "F"; break;
                    default: strRemainder = remainder + ""; break;
                }
                result = strRemainder + result;
                decimalNumber /= 16;
            }
            Console.WriteLine(result);
        }
    }
}
