using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Answers
{
    //write a c# program that display a menu of food item to theuser
    //prompt the user to enter a number to their choice use switch case to display item & price
    class _03_09_2024
    {
        static void Main()
        {
            Console.WriteLine("----------Veg Menu Card----------");
            Console.WriteLine("1.Burger\n2.Pizza\n3.Fries\n4.Rolls\n5.Pasta\n6.Maggie\n7.Exit");
            Console.WriteLine("Enter Your Choice For Price");
            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.WriteLine("You Choose Veg Burger & Price is:-200");
                    break;
                case 2:
                    Console.WriteLine("You Choose Veg Pizza & Price is:-250");
                    break;
                case 3:
                    Console.WriteLine("You Chooose Fries & Price is:-150");
                    break;
                case 4:
                    Console.WriteLine("You Choose Rolls & Price is:-125");
                    break;
                case 5:
                    Console.WriteLine("You Choose Pasta & Price is:-275");
                    break;
                case 6:
                    Console.WriteLine("You Choose Maggie & Price is:-100");
                    break;
                case 7:
                    Console.WriteLine("Invalid Choice Enter Correct Choice");
                    while (x != 7) ;
                    break;

            }
        }
    }
}
