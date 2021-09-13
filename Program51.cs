using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConApp01
{
    class Program51
    {
        static void Main(string[] args)
        {
            string[] items = new string[] { "Flower", "Plate", "Fruit", "Vegetables", "Picture" };

            var query = from item in items select item;

            foreach(var item in query)
                Console.WriteLine(item);

            int[] nums = new int[] { 10, 200, 3000, 40000 };

            var query1 = from num in nums select num;

            foreach (var num in nums)
                Console.WriteLine(num);

            List<int> values = new List<int> { 10, 200, 3000, 40000 };

            var query2 = from value in values select value;

            foreach (var value in values)
                Console.WriteLine(value);


        }
    }
}

/*
LINQ: Language Integrated Query

LINQ enables us to interact with any data source with single syntax
Data sources like Array, collection, file, database, etc...

In order to use LINQ feature we can use following ways:
1. SQL like queries
2. LINQ like queries
 */