using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    public static class IntegerExtensionMethods
    {
        public static int Square(this int n)//methods must be public and static
        {
            return n * n
;        }

        public static int Next(this int n)
        {
            return n + 1;
        }
    }

    class Program52
    {
        static void Main(string[] args)
        {
            int n = 9;
            Console.WriteLine(n);
            Console.WriteLine(n.Next());
            Console.WriteLine(n.Square());
            Console.WriteLine(n.Square().Next());
        }
    }
}
/*
Extension method: It is a method, which can be added to existing type to provide topup functionality.
 */