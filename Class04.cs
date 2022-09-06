using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class04
    {
        static void Main(String[] args)
        {
            double r, per_cir, PI = 3.14;
            Console.Write("Enter Radius Of a Circle : ");
            r = Convert.ToDouble(Console.ReadLine());

            per_cir = 2 * PI * r;
            Console.WriteLine("Perimeter of Circle is : {0}", per_cir);
        }
    
    }
}
