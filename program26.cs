using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class program26
    {
        static void Main(string[] args)
        {
            // Read 2 numbers and display division
            //handle overflow and divide by zero exception
            /*
            int ?a = null;
            int ?b = null;
            int ?c = null;

            try
            {
                Console.WriteLine("Enter 2 numbers: ");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Exception occured. and its description is: "+ ex.Message);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Exception encounterd and its description is: " + ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine($"The value is : {c}");
            }*/

            //===================================================================================================================

            //Array index out of range exception -- when specific indexed item is not available in array
            /*
            int[] items = new int[5] { 1, 2, 3, 4, 5 };
            try
            {
                Console.WriteLine(items[0]);
                Console.WriteLine(items[5]); // try to display 6th element
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }*/

            //===================================================================================================================
            try
            {
                int[] items = new int[5];
                Console.WriteLine("Enter 5 numbers: ");
                for(int i=0;i<6;i++)
                {
                    items[i] = Convert.ToInt32(Console.ReadLine());
                }
                for(int i=0;i<items.Length;i++)
                    Console.WriteLine(items[i]);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }        
        }
    }
}
