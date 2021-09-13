using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class baseClass
    {
        private int dm1 = 100; //this is accessible within the class only
        protected int dm2 = 200;//this is accessible within nd derived classes
        public int dm3 = 300; //this is accessible everywhere

        public void displayBase()
        {
            Console.WriteLine($"dm1 = {dm1}, dm2 = {dm2}, dm3 = {dm3}");
        }
    }

    class derivedClass:baseClass
    {
        public void displayDerived()
        {
            //dm1 is not accessible due to its protection level
            Console.WriteLine($"dm2 = {dm2}, dm3 = {dm3}");
        }
    }
    class Program35
    {
        static void Main(string[] args)
        {
            derivedClass o1 = new derivedClass();
            o1.displayBase();
            o1.displayDerived();
            Console.WriteLine(o1.dm3);
        }
    }
}

/*
Inheritance is the process of extending classes.
Inheritance is used acquire properties of base class to derived class.

Advantage:  Inheritance provides facility reusability with extendibility.

Real time Example:    Windows 8 operating system is an inheritance of Windows 7.
                       MyBook Version2 is an inheritance of Version1
*/