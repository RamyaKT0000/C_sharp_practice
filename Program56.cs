using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program56
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int> { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            Console.WriteLine(nums.First());
            Console.WriteLine("===========================");
            Console.WriteLine(nums.Last());
            Console.WriteLine("===========================");
            Console.WriteLine(nums.ElementAt(5));
            Console.WriteLine("===========================");

            Console.WriteLine(nums.Count());
            Console.WriteLine("===========================");
            Console.WriteLine(nums.Max());
            Console.WriteLine("===========================");
            Console.WriteLine(nums.Min());
            Console.WriteLine("===========================");
            Console.WriteLine(nums.Average());
            Console.WriteLine("===========================");

            foreach (int num in nums)
                Console.WriteLine(num);
            Console.WriteLine("===========================");

            foreach (int num in nums.Take(5))
                Console.WriteLine(num);
            Console.WriteLine("===========================");

            foreach (int num in nums.Skip(3))
                Console.WriteLine(num);
            Console.WriteLine("===========================");

            foreach (int num in nums.Take(6).Skip(1).Take(3))
                Console.WriteLine(num);
        }
    }
}
