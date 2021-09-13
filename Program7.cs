using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program7
    {
        static void Main(string[] args)
        {
            /*
            var: type is used to provide datatype based on value supplied
            variable with var type should not be empty, it assigned value at compile time.
            */

            var v1 = 100;
            Console.WriteLine($"v1 = {v1}, data type = {v1.GetType()}");

            var v2 = 15.2;
            Console.WriteLine($"v2 = {v2}, data type = {v2.GetType()}");

            var v3 = 'j';
            Console.WriteLine($"v3 = {v3}, data type = {v3.GetType()}");

            var v4 = "Hello"; 
            Console.WriteLine($"v4 = {v4}, data type = {v4.GetType()}");

            var v5 = true;
            Console.WriteLine($"v5 = {v5}, data type = {v5.GetType()}");

        }
    }
}
