using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class26
    {
        static void Main(String[] args)
        {
            string notes;
            char grd;

            Console.Write("Input the grade : ");
            grd = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (grd)
            {
                case 'E':
                    notes = " Excellent";
                    break;
                case 'V':
                    notes = " Very Good";
                    break;
                case 'G':
                    notes = " Good ";
                    break;
                case 'A':
                    notes = " Average";
                    break;
                case 'F':
                    notes = " Fails";
                    break;
                default:
                    notes = "Invalid Grade Found.";
                    break;
            }
            Console.Write("You have chosen  : {0}\n", notes);
        }
    }
}
