using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class08
    {
        public static void Main()
        {
            int n1, n2;
            bool bothEven;
            Console.Write("Input First number : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Second number : ");
            n2 = Convert.ToInt32(Console.ReadLine());

            bothEven = ((n1 % 2 == 0) && (n2 % 2 == 0)) ? true : false;

            Console.WriteLine(bothEven ? "The Total Of Numbers Is Even" : "The Total Of Numbers Is Odd");
        }
    }
}
