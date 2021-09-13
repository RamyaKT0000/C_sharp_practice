using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace ConApp01
{
    class Program45
    {
        static void Main(string[] args)
        {
            ArrayList items = new ArrayList();

            Console.WriteLine($"Capacity is: {items.Capacity}, count is: {items.Count}");

            items.Add("Scale");

            Console.WriteLine($"Capacity is: {items.Capacity}, count is: {items.Count}");

            items.Add("Pen");

            Console.WriteLine($"Capacity is: {items.Capacity}, count is: {items.Count}");

            items.Add("Eraser");

            Console.WriteLine($"Capacity is: {items.Capacity}, count is: {items.Count}");

            items.Add("Sharpner");

            Console.WriteLine($"Capacity is: {items.Capacity}, count is: {items.Count}");

            items.Add("Geometry");

            Console.WriteLine($"Capacity is: {items.Capacity}, count is: {items.Count}");
        }
    }
}
/*
Collection:    A collection is an API, contains inbuilt types of data structures
Each collection type has predefined methods and implementation

Advantages:
    Allow to store any type of data
    Any number of elements
    Define methods to perform operations like insert, delete, update, etc.,

Why collection?
    To overcome limtations of an array
    Array:    It is an abstract data type
    Used to group of similar elements within single identification

Limitations in Array:
    a) Array elements allow only one type of data
    b) Array size is fixed (cannot enhance)
    c) Array contains Length attribute only ( a separate count variable to be maintained)
    d) Operations like insert, delete, etc.,will be done by shifting elements

To overcome the limitation we use data structures

Data structures:
    Are based on dynamic memory allocations

OOPs languages provide inbuilt data structures in the form  Collection

questions:
1. how a collection object items allow different types of data?
Ans: Collection object type take object as parameter. and object all any type of data using boxing features

2. How a collection object allow unlimited items?
Ans: the default capacity is '0' and while adding 1st element the capacity increases to 4. 
while adding 5th element the capacity increases to 8 and so on.

available collection types:
1. arrayList
2. LinkedList
3. Hashtable
4. SortedList
5. etc

to perform operations on collection object the following methods are used:
1. Add();
2. Insert();
3. Remove();
4. RemoveAt();
5. TrimToSize();
6. Sort();
7. Reverse();
 */