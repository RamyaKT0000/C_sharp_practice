using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program8
    {
        static void Main(string[] args)
        {
            /*
            The datatypes used in .NET are available in a hierarchy called CTS(Common Type System)

            The root type is Object, all datatypes like int, string, char, etc, derived from Object type

            Object type variable allowed to store any type of data called boxing.
            Boxing refers to assign any type of data into object type.
            For same variable can assign any type of value for any number of times.
            but var will be assigned to only one value for one variable. and the data type will be assigned during compile time.

            Unboxing refers to dereference to boxed value
            */

            Object o1 = "Ramya"; //boxing
            Console.WriteLine(o1 + " " + o1.GetType());

            string name = o1.ToString(); // unboxing
            Console.WriteLine(name + " " + name.GetType());

            o1 = 1000; //boxing
            Console.WriteLine(o1 + " " + o1.GetType());

            int n = (int)o1; // unboxing
            Console.WriteLine(n + " " + n.GetType());


        }
    }
}
