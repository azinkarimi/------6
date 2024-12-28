using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apadana
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string res;

            Console.WriteLine("Enter your age:");
            age = int.Parse(Console.ReadLine());

            if (age > 20 && age < 30)
            {
                res = "Hello";
            }
            else { 
                res = "Bye";
            }

            Console.WriteLine(res + "dear...");

            Console.WriteLine("press any key to exit...");
            Console.ReadKey();
        }
    }
}
