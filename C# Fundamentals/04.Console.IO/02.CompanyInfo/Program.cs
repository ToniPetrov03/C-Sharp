using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CompanyInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string address = Console.ReadLine();
            string phone = Console.ReadLine();
            string fax = Console.ReadLine();
            string link = Console.ReadLine();
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string age = Console.ReadLine();
            string telOfManager = Console.ReadLine();


            Console.WriteLine(name);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Tel. " + phone);
            if (fax.Length == 0)
            {
                Console.WriteLine("Fax: (no fax)");
            }
            else
            {
                Console.WriteLine("Fax: " + fax);
            }
            Console.WriteLine("Web site: " + link);
            Console.WriteLine("Manager: " + firstName + " " + secondName + " (age: " + age + ", tel. " + telOfManager + ")");
        }
    }
}
