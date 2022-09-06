using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class06
    {
        static void Main(String[] args)
        {
            float r;
            float PI = 3.1415926535f;

            Console.Write("Radius : ");
            r = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine(4 * PI * (r * r));

            Console.WriteLine(4f / 3f * PI * (r * r * r));
        }
    }
    
}
