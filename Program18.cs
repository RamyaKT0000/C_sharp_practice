using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program18
    {
        static void Display()
        {
            Console.WriteLine("Hello From Methods...!");
        }

        static void DrawLine()
        {
            for(int i=0;i<100;i++)
            {
                Console.Write("=");
            }
            Console.WriteLine( );
        }

        static void Wishes(string name)
        {
            int hour = DateTime.Now.Hour;
            if(hour<12)
            {
                Console.WriteLine($"Hello {name}, Good Morning!...");
            }
            else if(hour<16)
            {
                Console.WriteLine($"Hello {name}, Good Afternoon!...");
            }
            else
            {
                Console.WriteLine($"Hello {name}, Good evening!...");
            }
        }
        
        static void Main(string[] args)
        {
            DrawLine();
            Display();
            DrawLine();

            Wishes("Ramya K T");
        }
    }
}

/*
Method is a function inside a class
Method is a self contained block of statements to perform a task
A method can return a value to the caller

-->Method can be defined as:
a. static: these methods will be called directly.
b. Regular: these methods will be called using Objects.

Main() is a static method. and 
Main() can invoke other static methods without creating object.

Parameterized methods: These are the methods contains arguments which take value from caller to process.
.Net method parameter can be following types:
a. Value type(default type)
b. ref type(reference type)
c. out type(used to have unassigned variable as argumrnt to get initialization)
d. params(used to have different number of arguments)
 */