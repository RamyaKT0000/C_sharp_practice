using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class student
    {
        private int id, fee;
        private string sname, course;

        //constructor overloading
        public student(int id, string sname, string course, int fee)
        {
            this.id = id;
            this.sname = sname;
            this.course = course;
            this.fee = fee;
        }

        public student(int id=-1, string sname="Not provided", int fee=10000) //default parameters
        {
            this.id = id;
            this.sname = sname;
            this.fee = fee;
        }

        public void getDetails()
        {
            Console.WriteLine($"{this.id}: {this.sname}: {this.course}: {this.fee}");
        }
    }
    class Program32
    {
        static void Main(string[] args)
        {
            student s1 = new student(1000, "Ramya", "B.E.", 100000);
            student s2 = new student(1001, "Raksha", 50000);
            student s3 = new student();

            s1.getDetails();
            s2.getDetails();
            s3.getDetails();
        }
    }
}
/*
Paramameterized constructor: Used to pass arguments while object creation
Note:   Constructor method can be overloaded
        Constructor method can have default parameter
    
 */
