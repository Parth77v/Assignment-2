using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class12
    {
        static void Main(String[] args)
        {
            int num;

            Console.Write("Input an integer : ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0)
                Console.WriteLine("{0} is a Positive Number.\n", num);
            else
                Console.WriteLine("{0} is a Negative Number. \n", num);
        }
    }
}
