using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program24
    {
        static void Main(string[] args)
        {
            int ?a = null;
            if(a is null)
            {
                Console.WriteLine("No value into the variable");
            }
            else
                Console.WriteLine($"value is {a}");

            string name = string.Empty;
            if(string.IsNullOrEmpty(name))
                Console.WriteLine("name is empty");
            else
                Console.WriteLine($"{name} is the value");
        }
    }
}
/*
Nullable types: used to have empty value into a variable
by prefix ? to the variable

int ?n = null;
To compare: 
if(n is null)
    statement

? behind a variable (eg: ?a) is called as nullable variable
 */