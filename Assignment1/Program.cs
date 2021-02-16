using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Assignment1
{
   class Program
    {
       
        static void Main(string[] args)
        {
            bool inputValidate = false, menuValidate = false;
            int userLength, userWidth;

            Console.WriteLine("Figure 1. Example Assignment 01 Solution");
            Console.WriteLine("-----------------------------------------\n");

            do
            {
                Console.Write("Please enter Length of rectangle: ");
                userLength = Convert.ToInt16(Console.ReadLine());
                
                Console.Write("Please enter Width of rectangle: ");
                userWidth = Convert.ToInt16(Console.ReadLine());

               
                if (userWidth > 0 && userLength > 0)
                {
                    inputValidate = true;
                    do
                    {
                        RectangleClass rcObj = new RectangleClass(userLength, userWidth);

                        Console.WriteLine(" 1. Get Rectangle Length \n 2. Change Rectangle Length \n 3. Get Rectangle Width \n 4. Change Rectangle Width" +
                               "\n 5. Get Rectangle Perimeter \n 6. Get Rectangle Area \n 7. Exit \n");
                        Console.Write("Please select any option from menu: ");
                        int menu = Int32.Parse(Console.ReadLine());
                        if (menu <= 7 && menu > 0)
                        {
                            menuValidate = true;
                            if (menu == 1){
                                Console.WriteLine("\n Length of Rectangle is: " + rcObj.GetLength());
                                Console.ReadLine();
                            }else if (menu == 2){
                                Console.WriteLine("\n New Length of Rectangle is: " + rcObj.SetLength(userLength));
                                Console.ReadLine();
                            }else if (menu == 3){
                                Console.WriteLine("\n Width of Rectangle is: " + rcObj.GetWidth());
                                Console.ReadLine();
                            }else if (menu == 4){
                                Console.WriteLine("\n New Width of Rectangle is: " + rcObj.SetWidth(userWidth));
                                Console.ReadLine();
                            }else if (menu == 5){
                                Console.WriteLine("\n Perimeter of Rectangle is: " + rcObj.GetPerimeter());
                                Console.ReadLine();
                            }else if (menu == 6){
                                Console.WriteLine("\n Area of Rectangle is: " + rcObj.GetArea());
                                Console.ReadLine();
                            }else if (menu == 7)
                                Console.Clear();
                        }
                    } while (menuValidate == false);
                }

                else
                    Console.WriteLine("\nYou did a mistake!! please enter a value");
            } while (inputValidate == false);
        }

    }
}
