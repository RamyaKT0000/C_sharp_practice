using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program22
    {
        static void display()
        {
            Console.WriteLine("Hello.. Good Morning...!");
        }

        static void display(string name)
        {
            Console.WriteLine($"Hello {name}.... Good Morning....!");
        }
        static void Main(string[] args)
        {
            display();
            display("Ramya");
        }
    }
}

/*
Method overloading: Refers to define more than one method with same name
 */