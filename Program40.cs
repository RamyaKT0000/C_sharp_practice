using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    interface IEmail
    {
        void compose();
        void inbox();
    }

    class GEmail : IEmail
    {
        public void compose()
        {
            Console.WriteLine("Code to send email");
            Console.WriteLine("This feature helps to write emails");

            Console.WriteLine("========================================");
        }

        public void inbox()
        {
            Console.WriteLine("Code to have inbox");
            Console.WriteLine("This feature helps to read recieved emails");

            Console.WriteLine("=========================================");
        }
    }
    class Program40
    {
        static void Main(string[] args)
        {
            IEmail email;
            email = new GEmail();

            email.compose();
            email.inbox();
        }
    }
}

/*
Interface:

Dont have any implementation

Interface is one of the type like class in oops programming.

Why do we need interface?
Interface is used as a contract, it contains only method specification (without implementation).
The methods in interface must implement in the derived classes

Points to note:    
    In C#.NET interface name should prefix with I (standard)
    The default access modifier in interface is public
    All the methods in interface are abstract
    Interface should not contains fields

C#.NET Collection API root type is IEnumerable is an Interface

IEnumerator if the return type of GetEnumerator in IEnumerable interface, which implement foreach loop
 */