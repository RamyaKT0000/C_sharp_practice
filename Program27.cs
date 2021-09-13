using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program27
    {
        static void Main(string[] args)
        {
            string[] names = { "Ramya", "Raksha", "Chaitra", "Thimmappa" };

            //foreach is also a looping structure which doesnot maintain index and can iterate only in forward direction.
            foreach(string name in names)
                Console.WriteLine(name);

            int[] items = { 10, 20, 30, 40, 50 };
            foreach(int item in items)
                Console.WriteLine(item);
        }
    }
}

