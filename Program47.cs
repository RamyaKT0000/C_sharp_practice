using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program47
    {
        static void Main(string[] args)
        {
            ArrayList items = new ArrayList(); //arraylist can have any type of datas

            items.Add("Ramya");

            items.Add('a');

            items.Add(69);

            items.Add(true);

            items.Add(69.96);

            foreach(var item in items)
                Console.WriteLine($"item is {item}, data type is {item.GetType()}");

        }
    }
}
