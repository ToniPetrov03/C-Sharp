using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.NextDate
{
    class NextDate
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int mounth = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            DateTime date = new DateTime(year, mounth, day);
            date = date.AddDays(1);
            Console.WriteLine(String.Format("{0:d.M.yyyy}", date));
        }
    }
}
