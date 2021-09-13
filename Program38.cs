using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program38
    {
        class EmpBaseClass
        {
            protected int id;
            protected string ename;
            protected string empType;
            protected int holiday;

            public EmpBaseClass(int id, string ename)
            {
                this.id = id;
                this.ename = ename;
            }

            public void getDetails()
            {
                Console.WriteLine($"Employee ID: {this.id} --> employee name: {this.ename}");
                Console.WriteLine($"Employee type: {this.empType} and number of holiday: {this.holiday} per month");

                Console.WriteLine("=================================================================");
            }
        }

        class PartTimeEmployee : EmpBaseClass
        {
            public PartTimeEmployee(int id, string ename) : base(id, ename)
            {
                this.empType = "PartTime";
                this.holiday = 1;
            }
        }

        class FullTimeEmployee : EmpBaseClass
        {
            public FullTimeEmployee(int id, string ename):base(id, ename)
            {
                this.empType = "FullTime";
                this.holiday = 2;
            }
        }

        static void Main(string[] args)
        {
            PartTimeEmployee e1 = new PartTimeEmployee(1001, "Ramya K T");
            FullTimeEmployee e2 = new FullTimeEmployee(1002, "Raksha K T");

            e1.getDetails();
            e2.getDetails();
        }
    }
}
