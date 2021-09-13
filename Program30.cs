using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class customer
    {
        private int id;
        private long mobile;
        private string cname, email;

        public void setDetails(int id, string cname, string email, long mobile)
        {
            this.id = id;
            this.cname = cname;
            this.email = email;
            this.mobile = mobile;
        }

        public void getDetails()
        {
            Console.WriteLine($"{this.id} : {this.cname} : {this.email} : {this.mobile}");
        }
    }

    class Program30
    {
        static void Main(string[] args)
        {
            customer c1 = new customer();
            customer c2 = new customer();
            customer c3 = new customer();
            customer c4 = new customer();

            c1.setDetails(101, "Thimmappa", "thimmappaks@gmail.com", 9449980749);
            c1.getDetails();

            c2.setDetails(102, "Chaitra", "chaitrasg@gmail.com", 8762287938);
            c2.getDetails();

            c3.setDetails(103, "Ramya", "ramyakt@gmail.com", 9449980649);
            c3.getDetails();

            c4.setDetails(104, "Raksha", "rakshakt@gmail.com", 6260180235);
            c4.getDetails();

        }
    }
}

/*
 * Define customer class with following members:
 * Data member: id, cname, email, mobile number
 * methods: setDetails(), getDetails()
 * data to be provided using setDetails() method arguments
 */