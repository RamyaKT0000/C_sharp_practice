using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program25
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer: ");
            int? n = null;

            try
            {
                //this block used to place statements which may provide exception
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException ex)
            {
                //This block used to handle exception
                Console.WriteLine("Input type not valid" + ex.Message);
                n = 0;
            }
            catch(Exception ex)
            {
                //This block used to handle exception
                Console.WriteLine("Error: " + ex.Message);
                n = 0;
            }
            finally
            {
                //This block processes statement even error raised or not
                Console.WriteLine($"Square of {n} is {n*n}");
            }


        }
    }
}
/*
Exception: is a runtime error:
A statemnt which cannot be understandable or which cannot be handled by program execution will be treated 
as runtime error or an exception

Like:
1. number divisible by zero
2. variable content value out of range
3. data type mismatch
4. array index out of range
5. Overflow exception- -- value is too smaller or bigger than given range
6. etc:

unassigned variable is considered as compile time error.

Exception Handling: Exception Handling is a mechanism in OOPs feature, to handle runtime errors.
Using Exception Handling we can divert the statement execution instead of termination.
    Keyword    Example/definition
    try        try keyword is used to create block to place the statements which may provide errors (suspicious statements). 
               try
               {         
                    c=a/b;
               }    
               try
               {
                    OpenFile a.txt;
               }    
               try
               {
                    int n =Covnert.ToInt32(Console.ReadLine());
               }
               The statements inside try block will not terminate, redirect to catch block.

    catch     This keyword is used to catch the exception and to handle it. Catch helps to continue the program without terminate. 
              The statements under the catch block get executed when the exception is raised.

    throw     throw keyword is used to throw a specified exception (This is optional block).

    finally     Used to execute the final statements in the exception handling

Ex:  File close, Disconnect DB (This is optional block)

 */