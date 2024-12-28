using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apadanaz_test
{
    class Program
    {
        static void Main(string[] args)
        {
            //چاپ 16 عدد + در 4 ردیف و 4 ستون
            int i = 1;

            while (i <= 16)
            {
                if (i % 4 == 0)
                    Console.Write("+\n");
                else
                    Console.Write("+");
                i++;
            }
            Console.WriteLine("pressx any key to exit...");
            Console.ReadKey();
        }
    }
}