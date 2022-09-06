using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class11
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Enter a Number : ");
            i = Convert.ToInt32(Console.ReadLine());

            if (i % 2 == 0)
                Console.WriteLine("Entered Number is an Even Number");
            else
                Console.WriteLine("Entered Number is an Odd Number");
        }
    }
}
