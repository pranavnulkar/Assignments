using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Collections
{
    internal class StackNonGenerics
    {
        static void Main()
        {
            //Create Object Of Stack 
            Stack st = new Stack();
            
            //Pushing Element In Stack LIFO 
            st.Push(101);
            st.Push(true);
            st.Push(10.09D);
            st.Push("A");
            st.Push(25000L);
            st.Push("Good Morning");

            //Print All elements Pushed In Stack
            Console.WriteLine("Entered Elements In Stack:-");
            foreach(var i in st)
            {
                Console.WriteLine(i);
            }

            //Remove(POP) Elements From Stack LIFO
            st.Pop();
            st.Pop();
            st.Pop();

            //Aftre Remove Elements From Stack Print The Values
           
            Console.WriteLine("\nAfter Removing Element The Stack Element Is:- ");
            foreach(var i in st)
            {
                Console.WriteLine(i);
            }
        }
    }
}
