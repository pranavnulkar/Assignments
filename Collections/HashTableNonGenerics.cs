using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Collections
{
    internal class HashTableNonGenerics
    {
        static void Main()
        {
            Hashtable hash = new Hashtable();
            hash.Add(01, "Audi");
            hash.Add(02, "BMW");
            hash.Add(03, "Porshe");
            hash.Add(04, "Range Rover");
            hash.Add(05, "Toyota");
            hash.Add(06, "Chevrolet");
            hash.Add(07, "Kia");
            hash.Add(08, "Maruti Suzuki");
            hash.Add(09, "Ford");
            hash.Add(10, "Tata");

            Console.WriteLine("Hash Table Element With Key Value Pair");
            foreach (DictionaryEntry table in hash)
            {
                Console.WriteLine($"{table.Key} {table.Value}");
            }

            hash.Remove(05);
            hash.Remove(09);

            Console.WriteLine("Hashtable After Applying Operation:- ");
            foreach (DictionaryEntry table in hash)
            {
                Console.WriteLine($"{table.Key} {table.Value}");
            }
        }
    }
}
