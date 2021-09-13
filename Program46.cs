using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConApp01
{
    class Program46
    {
        static void Main(string[] args)
        {
            ArrayList items = new ArrayList(45); //predefined capacity

            Console.WriteLine($"Capacity is: {items.Capacity}, Count is: {items.Count}");
            Thread.Sleep(500);

            items.Add("Eraser");
            items.Add("Scale");
            items.Add("Paper");

            Console.WriteLine($"Capacity is: {items.Capacity}, Count is: {items.Count}");
            Thread.Sleep(500);

            items.TrimToSize();

            Console.WriteLine($"Capacity is: {items.Capacity}, Count is: {items.Count}");
            Thread.Sleep(500);

            items.Add("Gum");

            Console.WriteLine($"Capacity is: {items.Capacity}, Count is: {items.Count}");
            Thread.Sleep(500);

        }
    }
}
