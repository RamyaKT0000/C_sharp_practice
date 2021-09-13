using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program23
    {
        static int square(int n)
        {
            return n *n;
        }

        static int Factorial(int n)
        {
            if (n == 1 || n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }

        static int Reverse(int n)
        {
            int rev = 0;
            int rem = 0;

            while(n!=0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n = n / 10;
            }

            return rev;
        }

        static int Addition(int a, int b)
        {
            return a + b;
        }

        static int Biggest(int a, int b)
        {
            /*
            if (a > b)
                return a;
            else
                return b;*/
            return a > b ? a : b;
        }

        static int Smallest(int a, int b)
        {
            /*
            if (a < b)
                return a;
            else
                return b;*/
            return a < b ? a : b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(square(6));
            Console.WriteLine(Factorial(6));
            Console.WriteLine(Reverse(645));

            Console.WriteLine(Addition(10,20));
            Console.WriteLine(Biggest(10,20));
            Console.WriteLine(Smallest(10,20));
        }
    }
}
/*
Method returning values: Referes to a method contains a definition which takes arguments, compute and return value to the caller.
 */