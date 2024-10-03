using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Collections
{
    internal class DictionaryGenerics
    {
        static void Main()
        {
            //Create Object Of Dictionary
            Dictionary<String, int> carpair = new Dictionary<String, int>();

            //Add Elements in Dictionary
            carpair.Add("BMW", 2500000);
            carpair.Add("AUDI", 3000000);
            carpair.Add("THAR", 3200000);
            carpair.Add("JAGUAR", 3500000);
            carpair.Add("TOYOTA", 2500000);
            carpair.Add("KIA", 2000000);
            carpair.Add("FORD", 3700000);
            carpair.Add("TATA", 1000000);
            carpair.Add("MARUTI SUZUKI", 1200000);
            carpair.Add("RENAULT", 1200000);

            //Print All Element From Dictionary
            Console.WriteLine("Entered Element In Dictionary With Key Value Pair");
            foreach(KeyValuePair<string, int> kvp in carpair)
            {
                Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            }

            //Modify element In Dictionary
            if (carpair.ContainsKey("MARUTI SUZUKI"))
            {
                carpair["MARUTI SUZUKI"] = 1500000;
            }
            if (carpair.ContainsKey("AUDI")) 
            {
                carpair["AUDI"] = 4500000;
            }

            //Print All Modified Element From Dictionary
            Console.WriteLine("\nAfter Modifying Element Dictionary Is:- ");
            foreach(KeyValuePair<string,int> kvp in carpair) 
            {
                Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            }

            //Remove The Element from Dictionary
            if (carpair.ContainsKey("TOYOTA"))
            {
                carpair.Remove("TOYOTA");
            }
            if (carpair.ContainsKey("TATA"))
            {
                carpair.Remove("TATA");
            }

            //After Removing Element From Dictionary
            Console.WriteLine("\nAfter Removing Element From Distionary Is:- ");
            foreach(KeyValuePair<string,int> kvp in carpair)
            {
                Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            }

            //Clear The Dictionary Element
            carpair.Clear();

            //After Clear Dictionary Element Count in Dictionary
            Console.WriteLine($"\nAfter Clear Dictionary Count In Dictionary:- {carpair.Count}");
        }
    }
}
