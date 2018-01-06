using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double eps = 0.000001;
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            double difference = number1 - number2;
            if (difference < 0)
            {
                difference = -difference;
            }
            if (difference < eps)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
