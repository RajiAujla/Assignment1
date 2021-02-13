using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Figure 1. Example Assignment 01 Solution");
            Console.WriteLine("-----------------------------------------\n");
            Console.WriteLine("Enter Length of rectangle:");
            int userLength = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Width of rectangle");
            int userWidth = Convert.ToInt16(Console.ReadLine());

            RectangleClass obj = new RectangleClass(userLength, userWidth);

        }
    }
}
