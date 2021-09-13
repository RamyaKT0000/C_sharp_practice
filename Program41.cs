using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    partial class MyClass
    {
        public void display1()
        {
            Console.WriteLine("Hello from display1");
        }
    }

    partial class MyClass
    {
        public void display2()
        {
            Console.WriteLine("Hello from display2");
        }
    }

    class Program41
    {
        static void Main(string[] args)
        {
            MyClass o1 = new MyClass();
            o1.display1();
            o1.display2();
        }
    }
}
/*
partial classes are partially implemented.

A class which can be implemented more than once. but method name should not be same. Class name must be same.
and must be preceeded by partial keyword.

 */