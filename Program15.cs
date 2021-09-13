using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program15
    {
        static void Main(string[] args)
        {
            int[] items; //array declaration
            items = new int[5]; //array size assignment

            items[0] = 1000;
            items[1] = 2000;
            items[2] = 3000;
            items[3] = 4000;
            items[4] = 5000;

            Console.WriteLine($"{items[0]}");
            Console.WriteLine($"{items[1]}");
            Console.WriteLine($"{items[2]}");
            Console.WriteLine($"{items[3]}");
            Console.WriteLine($"{items[4]}");

            Console.WriteLine("=====================");

            for(int i=0;i<5;i++)
            {
                Console.WriteLine($"{items[i]}");
            }

            Console.WriteLine("=====================");

            //======================================================================================

            int[] arr = new int[5] { 100, 200, 300, 400, 500 }; //array initialization
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine($"{arr[i]}");
            }

            Console.WriteLine("=====================");

            //======================================================================================

            int[] arr1 = new int[5];

            Console.WriteLine("Enter array inputs: ");
            for(int i=0;i<arr1.Length;i++)
            {
                Console.WriteLine($"Enter value for arr1[{i}]");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0;i<arr1.Length;i++)
            {
                Console.WriteLine($"arr1[{i}] = {arr1[i]}");
            }

            Console.WriteLine("=====================");

            //======================================================================================

            //Read 5 names into array and display with position
            string[] names = new string[5];

            Console.WriteLine("Enter 5 names: ");

            for(int i=0;i<names.Length;i++)
            {
                Console.WriteLine($"Enter {i+1} name: ");
                names[i] = Console.ReadLine();
            }

            for(int i=0;i<names.Length;i++)
            {
                Console.WriteLine($"names[{i+1}] = {names[i]}");
            }

            Console.WriteLine("=====================");

            //======================================================================================

            int[] values = new int[5];

            Console.WriteLine("Enter array values: ");

            int sum = 0;
            int count = values.Length;
            double avg = 0;
            int big = 0, small = 0;

            for(int i=0;i<count;i++)
            {
                Console.WriteLine($"Enter value for values[{i}]: ");
                values[i] = Convert.ToInt32(Console.ReadLine());
                if(i==0)
                {
                    big = small = values[0];
                }
                else if(values[i]>big)
                {
                    big = values[i];
                }
                else if(values[i]<small)
                {
                    small = values[i];
                }

                sum += values[i];
            }

            avg = (double) sum / count;

            for(int i=0;i<count;i++)
            {
                Console.WriteLine($"values[{i}] : {values[i]}");
            }

            Console.WriteLine($"Count of elements: {count}");
            Console.WriteLine($"sum of elements: {sum}");
            Console.WriteLine($"Average of elements: {avg}");
            Console.WriteLine($"Biggest of elements: {big}");
            Console.WriteLine($"Smallest of elements: {small}");

            Console.WriteLine("=====================");

            //======================================================================================

            //Assign 5 names into string array (name should be full name with 2 or 3 words)
            //Display all names followed by firstname  and lastname in 3 columns

            string[] namesArr = new string[5];

            namesArr[0] = "Ramya K T";
            namesArr[1] = "Raksha K T";
            namesArr[2] = "Thimmappa K S";
            namesArr[3] = "Chaitra S G";
            namesArr[4] = "Nagarathna Bhat G";

            Console.WriteLine($"{namesArr[0]} --> {namesArr[0].Substring(0, namesArr[0].IndexOf(" "))} --> {namesArr[0].Substring(namesArr[0].LastIndexOf(" "))}");
            Console.WriteLine($"{namesArr[1]} --> {namesArr[1].Substring(0, namesArr[1].IndexOf(" "))} --> {namesArr[1].Substring(namesArr[1].LastIndexOf(" "))}");
            Console.WriteLine($"{namesArr[2]} --> {namesArr[2].Substring(0, namesArr[2].IndexOf(" "))} --> {namesArr[2].Substring(namesArr[2].LastIndexOf(" "))}");
            Console.WriteLine($"{namesArr[3]} --> {namesArr[3].Substring(0, namesArr[3].IndexOf(" "))} --> {namesArr[3].Substring(namesArr[3].LastIndexOf(" "))}");
            Console.WriteLine($"{namesArr[4]} --> {namesArr[4].Substring(0, namesArr[4].IndexOf(" "))} --> {namesArr[4].Substring(namesArr[4].LastIndexOf(" "))}");
        }
    }
}

/*
Array is a programming feature, allows to store more than one value in within a single identification and programmable.
All elements will store in homogeneous order. Arrays are the best place to handle limited number of elements.

Application of an array: Days in a month, Hours in a day, students in a classroom, seats in a bus, etc.

Points to note:
Array is an abstract class in .NET collection API
Array declared at compile time(stored in stack memory)
Arrays are index based collection, accessible using [] notation.
first element is accessible using 0 index, last element is accessible using Length-1 as index
Dimensions are accessible using Rank Property.

Limitations:
Array variable store one type of data.
Array variable size is fixed (cannot enhance)
inset=rtion, deletion, sorting and searching of elements in array is big process.
 */
