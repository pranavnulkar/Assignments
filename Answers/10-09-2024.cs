using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Answers
{

    public enum Year
    {
        JANUARY,
        FEBRUARY,
        MARCH,
        APRIL,
        MAY,
        JUNE,
        JULY,
        AUGUEST,
        SEPTEMBER,
        OCTOBER,
        NOVEMBER,
        DECEMBER
    }

    class _10_09_2024
    {
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Enter Month : ");
                string x = Console.ReadLine().ToUpper();

                Year month = (Year)Enum.Parse(typeof(Year), x);
                //Year month = Year.January;


                switch (month)
                {
                    case Year.JANUARY:
                        Console.WriteLine("You Entered JANUARY Month");
                        break;
                    case Year.FEBRUARY:
                        Console.WriteLine("You Entered FEBRUARY Month");
                        break;
                    case Year.MARCH:
                        Console.WriteLine("You Entered MARCH Month");
                        break;
                    case Year.APRIL:
                        Console.WriteLine("You Entered APRIL Month");
                        break;
                    case Year.MAY:
                        Console.WriteLine("You Entered MAY Month");
                        break;
                    case Year.JUNE:
                        Console.WriteLine("You Entered JUNE Month");
                        break;
                    case Year.JULY:
                        Console.WriteLine("You Entered JULY Month");
                        break;
                    case Year.AUGUEST:
                        Console.WriteLine("You Entered AUGUEST Month");
                        break;
                    case Year.SEPTEMBER:
                        Console.WriteLine("You Entered SEPTEMBER Month");
                        break;
                    case Year.OCTOBER:
                        Console.WriteLine("You Entered OCTOBER Month");
                        break;
                    case Year.NOVEMBER:
                        Console.WriteLine("You Entered NOVEMBER Month");
                        break;
                    case Year.DECEMBER:
                        Console.WriteLine("You Entered DECEMBER Month");
                        break;
                }
                if (month == Year.JANUARY)
                {
                    Console.WriteLine("JANUARY is Start Month Of Year");
                    Console.WriteLine("");
                }
                else if (month == Year.DECEMBER)
                {
                    Console.WriteLine("DECEMBER Is End Month Of Year");
                    Console.WriteLine("");
                }
                else
                {
                    break;
                }
            }
        }
    }
}
