using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program48
    {
        static void Main(string[] args)
        {
            ArrayList items = new ArrayList();

            items.Add(100);
            items.Add(20);
            items.Add(5);
            items.Add(10);
            items.Add(69);

            items.Sort();

            for(int i=0; i<items.Count;i++)
                Console.WriteLine(items[i]);
            Console.WriteLine("============================");
            
            items.Reverse();

            for (int i = 0; i < items.Count; i++)
                Console.WriteLine(items[i]);
            Console.WriteLine("============================");
        }
    }
}
