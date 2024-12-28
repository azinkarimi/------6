using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apadana_test
{
    class Program
    {
        static void Main(string[] args)
        {

            int num, i = 2;
            string res = "prime";

            Console.WriteLine("Please enter 1 num:");

            num = int.Parse(Console.ReadLine());

            while (i < num)
            {
                if (num % i == 0)
                {
                    res = "not prime";
                    break;
                }
                i++;
            }
            Console.WriteLine("The num is" + res);
            Console.WriteLine("press any key to exit...");
            Console.ReadKey();
        }
    }
}
      
