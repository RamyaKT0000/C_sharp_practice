using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class parentClass
    {
        public parentClass()
        {
            Console.WriteLine("Parent class constructor");
        }
    }

    class intermediateClass:parentClass
    {
        public intermediateClass()
        {
            Console.WriteLine("intermediate class constructor");
        }
    }

    class childClass:intermediateClass
    {
        public childClass()
        {
            Console.WriteLine("child class constructor");
        }
    }
    class Program36
    {
        static void Main(string[] args)
        {
            childClass c1 = new childClass();
        }
    }
}
