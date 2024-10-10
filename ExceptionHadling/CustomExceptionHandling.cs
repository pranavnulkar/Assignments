using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.ExceptionHadling
{
    class CustomExceptionHandling
    {
        class NegativeNumberException : Exception
        {
            public NegativeNumberException(string message):base(message) { }
        }

        static void Main()
        {
            try
            {
                Console.WriteLine("Enter Any Positive Number");
                double num = Convert.ToDouble(Console.ReadLine());

                if (num < 0)
                {
                    throw new NegativeNumberException("Entered Number Is Negative");
                }
                Console.WriteLine($"You Entered Positive Number {num}");
            }
            catch (NegativeNumberException ex)
            {
                Console.WriteLine($"Error:- {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Input Format Is Incorrect Please Enter Correct Format");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
