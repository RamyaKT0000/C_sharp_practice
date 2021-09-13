using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class ConstructorDemo
    {
        public ConstructorDemo()
        {
            Console.WriteLine("Object instantiation...");
        }
    }

    class Program31
    {
        static void Main(string[] args)
        {
            ConstructorDemo o1 = new ConstructorDemo();
            ConstructorDemo o2 = new ConstructorDemo();

        }
    }
}
/*
 * Constructor: This method is used to instantiate data members
 * This is a special method
 * a. Exist with same name of the class
 * b. Invoke implicitly
 * 
 * Scenario: The initial formalities while joining in company will be done using constructor.
 */