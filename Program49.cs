using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program49
    {
        static void Main(string[] args)
        {
            Hashtable occupation = new Hashtable();

            occupation.Add("emp1", "Ramya");
            occupation.Add("Student", "Raksha");
            occupation.Add("emp2", "Chaitra");
            occupation.Add("Agriculturist1", "Thimmappa");
            occupation.Add("Housewife", "Nagarathna");
            occupation.Add("Agriculturist2", "Ganapathi");

            if(occupation.Contains("emp2"))
                Console.WriteLine(occupation["emp2"].ToString());

            Console.WriteLine();

            Console.WriteLine("Enter key: ");
            string key = Console.ReadLine();

            if(occupation.Contains(key))
                Console.WriteLine(occupation[key].ToString());
            else
                Console.WriteLine($"{key} not exist...");

            Console.WriteLine();

            foreach(DictionaryEntry o in occupation)
                Console.WriteLine($"key  = {o.Key}, value= {o.Value}");



            SortedList jobs = new SortedList();

            jobs.Add("emp1", "Ramya");
            jobs.Add("Student", "Raksha");
            jobs.Add("emp2", "Chaitra");
            jobs.Add("Agriculturist1", "Thimmappa");
            jobs.Add("Housewife", "Nagarathna");
            jobs.Add("Agriculturist2", "Ganapathi");

            if (jobs.Contains("emp2"))
                Console.WriteLine(jobs["emp2"].ToString());

            Console.WriteLine();

            Console.WriteLine("Enter key: ");
            string keys = Console.ReadLine();

            if (jobs.Contains(keys))
                Console.WriteLine(jobs[keys].ToString());
            else
                Console.WriteLine($"{keys} not exist...");

            Console.WriteLine();

            foreach (DictionaryEntry j in jobs)
                Console.WriteLine($"key  = {j.Key}, value= {j.Value}");
        }
    }
}
/*
Hashtable: it is a key and value paired collection
Key must not be repeated but value can be repeated

DictionaryEntry type contains key and value as properties
using DictionaryEntry we can iterate in hash table

Sorted list is a key and value paired collection, which stores data in insertion sort logic
 */