using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program50
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string> { "Banana", "Cherry", "Papaya", "Apple" };

            foreach(string f in fruits)
                Console.WriteLine(f);

            List<int> items = new List<int> { 10, 20, 30 };
            items.Insert(0, 5);
            items.Add(40);

            foreach(int i in items)
                Console.WriteLine(i);
        }
    }
}

/*
Generic type used to restrict type in the collection
 */