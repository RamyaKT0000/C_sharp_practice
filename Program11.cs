using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program11
    {
        static void Main(string[] args)
        {
            //Display wishes based on time.

            int hr = DateTime.Now.Hour;

            if(hr < 12)
                Console.WriteLine("Good Morning !");
            else if(hr < 16)
                Console.WriteLine("Good Afternoon !");
            else
                Console.WriteLine("Good Evening !");

            string day = DateTime.Now.DayOfWeek.ToString().Substring(0, 3).ToLower();
            if(day == "sat" || day == "sun")
                Console.WriteLine("Today is weekend and enjoy with your family !");
            else
                Console.WriteLine("Today is weekday and enjoy with office works !");
        }
    }
}
