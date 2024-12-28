using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test__Apadana
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("a=" + a + "b=" + b);

            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a=" + a + "b=" + b);
            Console.ReadKey();

        }
    }
}
