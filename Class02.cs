using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class02
    { 
        static void Main(string[] args)
        { 
        Console.Write("Input a number : ");
            int num = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the desired width : ");
            int width = Convert.ToInt32(Console.ReadLine());

        int height = width;
            for (int row = 0; row<height; row++)
            {
                for (int column = 0; column<width; column++)
                {
                    Console.Write(num);
                }

        Console.WriteLine();
                width--;
            }
        }
    }
}
