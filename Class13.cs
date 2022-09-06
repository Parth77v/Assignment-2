using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class13
    {
        static void Main(String[] args)
        {
            int year;

            Console.Write("Input an Year : ");
            year = Convert.ToInt32(Console.ReadLine());

            if ((year % 400) == 0)
                Console.WriteLine("{0} is a leap year.\n", year);
            else if ((year % 100) == 0)
                Console.WriteLine("{0} is not a leap year.\n", year);
            else if ((year % 4) == 0)
                Console.WriteLine("{0} is a leap year.\n", year);
            else
                Console.WriteLine("{0} is not a leap year.\n", year);
        }
    }
}
