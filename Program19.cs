using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program19
    {
        static void Display(int a , int b)
        {
            Console.WriteLine( $"a= {a}, b= {b}");
        }

        static void square(ref int a, ref int b)
        {
            a *= a;
            b *= b;
        }

        static void swap(ref int e, ref int f)
        {
            int temp = e;
            e = f;
            f = temp;
        }

        static void Main(string[] args)
        {
            int a = 100, b = 200;

            Console.WriteLine("Before Square: ");
            Display(a, b);

            /* ref: used for passing or returning references of values to or from methods. 
            Basically it means that any changes made to a value that is passed by reference will reflect this change 
            since you are modifying the value at the address and not just the value {similar to pointers in C} */

            square(ref a, ref b); // The only method defintion having ref will be execited and kept the value as it is

            Console.WriteLine("After Square: ");
            Display(a, b);

            Console.WriteLine("==========================================");

            //=====================================================

            int c = 15, d = 20;

            Console.WriteLine($"Before swapping: c--> {c} and d--> {d}");

            swap(ref c, ref d); // call by reference

            Console.WriteLine($"After swapping: c--> {c} and d--> {d}");

        }
    }
}
