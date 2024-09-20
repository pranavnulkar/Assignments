using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class _04_09_2024
    {
        static void Main()
        {
            //for each loop
            string[] mob_brands = { "APPLE", "SAMSUNG", "VIVO", "POCO", "BLACKBERRY", "NOKIA", "OPPO", "ONEPLUS", "REALME", "MOTOROLA" };

            foreach (string mobiles in mob_brands)
            {
                Console.WriteLine("Top 10 Mobile Brands :- " + mobiles);
            }

            /*WAP that user enter no if the user enter a negative no use the break statment to
            exit the loop and display the sum of all entered numbers.
            Break Statemnt */
            Console.WriteLine();
            Console.WriteLine("=====Addition Of Numbers=====");
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Enter  Number");
                int num1 = Convert.ToInt32(Console.ReadLine());

                if (num1 < 0)
                {
                    break;
                }
                sum += num1;
            }
            Console.WriteLine("The Sum Of All Entered Number Is : " + sum);


            //continue statment
            Console.WriteLine();
            Console.WriteLine("=====Using Continue Statement=====");
            Console.WriteLine("1 To 20 Expect Numbers Expect Divisible By 3");
            int x = 1;
            for (x = 1; x <= 20; x++)
            {
                if (x % 3 == 0)
                {
                    continue;
                }
                Console.WriteLine("Iteration From 1 to 20 :-" + x);
            }

            /*WAP for a goto statment to repeat a block of code unit the 
             * user enter a valid age between 1 to 120  Goto Statment */
            Console.WriteLine();
        start:
            Console.WriteLine("Enter Age Between 1 to 120");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 1 && age <= 120)
            {
                Console.WriteLine("Your Age Is : " + age);
            }
            else
            {
                Console.WriteLine("Please Enter Valid Age");
                goto start;
            }
        }
    }
}
