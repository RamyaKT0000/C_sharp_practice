using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    /*
    //create number class
    class Number
    {
        //data members section
        private int num1;

        //member function section
        public void setNumber(int num1)
        {
            this.num1 = num1;
        }

        public void getNumber()
        {
            Console.WriteLine($"num1 = {this.num1}");
        }
    }

    class Program28
    {
        static void Main(string[] args)
        {
            Number n1 = new Number();
            n1.setNumber(100);
            n1.getNumber();
        }
    }
    */

    //create number class
    class Number
    {
        //data members section
        private int num1, num2;

        //member function section
        public void setNumbers(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public void getNumbers()
        {
            Console.WriteLine($"num1 = {this.num1}");
            Console.WriteLine($"num2 = {this.num2}");
        }
    }

    class Program28
    {
        static void Main(string[] args)
        {
            Number n1 = new Number();
            n1.setNumbers(150, 300);
            n1.getNumbers();
        }
    }
}

/*
Class:    It is a user defined data type

Object:    Instance of a class

Date member:    Refers to variable inside a class

Member function:    Refers to function inside a class

private:    Access modifier restrict access of member to outside

public:        Acess modifier allow access of member to outside

to have security use set and get method.
 */