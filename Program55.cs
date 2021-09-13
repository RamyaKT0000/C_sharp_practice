using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program55
    {
        /*
        static void Main(string[] args)
        {
            List<string> fruits = new List<string> { "Banana", "mango", "apple", "pineapple" };

            Console.WriteLine(fruits.First());
            Console.WriteLine(fruits.Last());
            Console.WriteLine(fruits.ElementAt(2));
            Console.WriteLine(fruits.Count());
        }
        */

        static void Main(string[] args)
        {
            List<string> fruits = new List<string> { "Banana", "mango", "apple", "pineapple", "cherry","pomegranate", "lemon", "jackfruit", "guaua", "orange","watermelon" };

            foreach(string fruit in fruits.Take(3))
                Console.WriteLine(fruit);

            Console.WriteLine("===================================");

            foreach(string fruit in fruits.Skip(2))
                Console.WriteLine(fruit);

            Console.WriteLine("===================================");
            
            foreach (string fruit in fruits.Skip(2).Take(3))
                Console.WriteLine(fruit);
        }
    }
}
/* 
Linq support 2 types of queries
1. Sql like queries
2. linq like queries: provided in built extension mehtods
 */