using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.ExceptionHadling
{
    class ExceptionHandling
    {
        static void Main()
        {
            while (true)
            {
                try
                {


                    Console.WriteLine("Enter First Number");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Entre Second Number");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Choose Operation +,-,*,/");
                    char operation = Console.ReadKey().KeyChar;

                    double result = 0;

                    if (operation == '+')
                    {
                        result = num1 + num2;
                    }
                    else if (operation == '-')
                    {
                        result = num1 - num2;
                    }
                    else if (operation == '*')
                    {
                        result = num1 * num2;
                    }
                    else if(operation == '/')
                    {
                        if (num2 == 0)
                        {
                            throw new DivideByZeroException("\nCannot Divide By Zero Enter Number Greater Than 0");
                        }
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Operation Choose Correct Operation +,-,*,/");
                        continue;
                    }
                    Console.WriteLine($"\nResult:- {result}");
                }
                catch(FormatException)
                {
                    Console.WriteLine("Input Format Is Incorrect");
                }
                //catch(DivideByZeroException ex)
                //{
                //    Console.WriteLine(ex.Message);
                //}
                catch (OverflowException)
                {
                    Console.WriteLine("\nThe Operation Result in a overflow Please Use Smaller Number");
                }
                catch(ArithmeticException ex)
                {
                    Console.WriteLine($"\nArithmatic Error:- {ex.Message}");
                }

                Console.WriteLine("Do you Want To Perform Other Operation Press(Y/N)");
                if (Console.ReadKey().KeyChar != 'y')
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
