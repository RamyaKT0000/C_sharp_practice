using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class person
    {
        private string pname, gender;
        private int age;

        public void setDetails(string pname, string gender, int age)
        {
            this.pname = pname;
            this.gender = gender;
            this.age = age;
        }

        public void getDetails()
        {
            Console.WriteLine($"{this.pname} --> {this.gender} --> {this.age}");
        }
    }

    class Program29
    {
        static void Main(string[] args)
        {
            person p1 = new person();
            person p2 = new person();

            p1.setDetails("Ramya", "female", 21);
            p1.getDetails();

            p2.setDetails("Kiran- Trainer", "male", 38);
            p2.getDetails();
        }
    }
}

/* define person class with pname, gender and age as data members
 * implement setDetails() and getDetails() method
 * Declare 2 object access
 */