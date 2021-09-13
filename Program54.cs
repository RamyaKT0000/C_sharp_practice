using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program54
    {
        /*
        static void Main(string[] args)
        {
            Action display = delegate ()
            {
                Console.WriteLine("Hello from display");
            };

            Action<string> wishes = delegate (string name)
            {
                Console.WriteLine($"Hello {name}");
            };

            display();
            wishes("Ramya");
        }
        */

        /*
        static void Main(string[] args)
        {
            Func<int, int> square = delegate (int n)
            {
               return n * n;
            };

            Func<int, int> Next = delegate (int n)
             {
                 return n + 1;
             };

            Console.WriteLine(Next(9));
            Console.WriteLine(square(5));
        }
        */

        static void Main(string[] args)
        {
            Predicate<int> IsZero = delegate (int n)
            {
                if (n == 0)
                    return true;
                else
                    return false;
            };

            Predicate<int> IsPositive = delegate (int n)
            {
                if (n > 0)
                    return true;
                else
                    return false;
            };

            int n = 6;
            if(IsZero(n))
                Console.WriteLine("Input is 0");
            else if(IsPositive(n))
                Console.WriteLine($"{n} is +ve");
            else
                Console.WriteLine($"{n} is -ve");
        }
    }
}
/*
Delegate: is a type safe function pointer.

the object of delegate can be referred to a function or set of functions.

eg: every employee is an object
the reference will be hold by project allocator

project allocator is like a delegate decide the employee assignment

.Net provided 3 inbuilt delegates
1. action: refers to a function perform a task and without returning value
2. func: refers to a function return a value
3. predicate: referes to a function return boolean value
 */