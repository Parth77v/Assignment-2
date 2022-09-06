using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class01
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Letter : ");
            String l1 = Console.ReadLine();
            Console.Write("Enter Second Letter : ");
            String l2 = Console.ReadLine();
            Console.Write("Enter Third Letter : ");
            String l3 = Console.ReadLine();
            Console.WriteLine(l3 + " " + l2 + " " + l1);
        }
    }
}