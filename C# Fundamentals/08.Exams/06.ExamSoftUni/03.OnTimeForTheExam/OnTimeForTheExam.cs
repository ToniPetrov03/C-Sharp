using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.OnTimeForTheExam
{
    class OnTimeForTheExam
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int hourOfArrival = int.Parse(Console.ReadLine());
            int minuteOfArrival = int.Parse(Console.ReadLine());

            if (hours * 60 + minutes - (hourOfArrival * 60 + minuteOfArrival) == 0)
            {
                Console.WriteLine("On time");
            }
            else if (hours * 60 + minutes - (hourOfArrival * 60 + minuteOfArrival) > 0
                && hours * 60 + minutes - (hourOfArrival * 60 + minuteOfArrival) < 31)
            {
                Console.WriteLine("On time");
                Console.WriteLine(hours * 60 + minutes - (hourOfArrival * 60 
                    + minuteOfArrival) + " minutes before the start");
            }
            else if (hours * 60 + minutes - (hourOfArrival * 60 + minuteOfArrival) > 30
                && hours * 60 + minutes - (hourOfArrival * 60 + minuteOfArrival) < 60)
            {
                Console.WriteLine("Early");
                Console.WriteLine(hours * 60 + minutes - (hourOfArrival * 60
                    + minuteOfArrival) + " minutes before the start");
            }
            else if (hours * 60 + minutes - (hourOfArrival * 60 + minuteOfArrival) > 59)
            {
                Console.WriteLine("Early");
                if (minuteOfArrival > minutes)
                {
                    Console.WriteLine((hours - hourOfArrival) - 1 + ":"
                        + (60 + minutes - minuteOfArrival) + " hours before the start");
                }
                else
                {
                    Console.WriteLine((hours - hourOfArrival) + ":"
                        + (minutes - minuteOfArrival) + " hours before the start");
                }
            }
            else if (hourOfArrival * 60 + minuteOfArrival - (hours * 60 + minutes) > 0
                && hourOfArrival * 60 + minuteOfArrival - (hours * 60 + minutes) < 60)
            {
                Console.WriteLine("Late");
                Console.WriteLine(hourOfArrival * 60 + minuteOfArrival - (hours * 60
                    + minutes) + " minutes after the start");
            }
            else if (hourOfArrival * 60 + minuteOfArrival - (hours * 60 + minutes) > 59)
            {
                Console.WriteLine("Late");
                if (minutes > minuteOfArrival)
                {
                    Console.WriteLine((hourOfArrival - hours) - 1 + ":"
                        + (60 + minuteOfArrival - minutes) + " hours after the start");
                }
                else
                {
                    Console.WriteLine((hourOfArrival - hours)  + ":"
                        + (minuteOfArrival - minutes) + " hours after the start");
                }
            }
        }
    }
}
