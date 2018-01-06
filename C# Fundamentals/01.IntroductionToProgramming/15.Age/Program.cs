using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Age
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthdate = DateTime.Parse(Console.ReadLine());
            TimeSpan difference = DateTime.Now - birthdate;
            int myYears = (difference.Days / 365) - 1;
            Console.WriteLine(myYears);
            Console.WriteLine(myYears + 10);
        }
    }
}
