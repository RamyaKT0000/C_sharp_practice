using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program10
    {
        static void Main(string[] args)
        {
            /*
             DateTime: Used to get current date and time related values and it is inbuilt structure.
             */

            Console.WriteLine(DateTime.Now);

            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongDateString());

            Console.WriteLine(DateTime.Now.ToShortTimeString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());

            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.DayOfWeek.ToString());

        }
    }
}
