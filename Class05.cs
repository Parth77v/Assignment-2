using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class05

    {
        static void Main(String[] args)
        {
            double distance, time, speed;
            Console.Write("Enter Distance [in Kilometer(s)] : ");
            distance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Time [in hour(s)] : ");
            time = Convert.ToDouble(Console.ReadLine());

            speed = distance / time;
            Console.WriteLine("Speed is : {0}KM/h", speed);
        }
    }
}
