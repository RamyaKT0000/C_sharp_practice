using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class bankAccount
    {
        //data members:
        private int accountBalance;
        private string cname, status;

        //member functions:
        public bankAccount(string cname = "Not provided" , int amount = 0)
        {
            this.cname = cname;
            this.accountBalance = amount;

            if (DateTime.Now.Day.ToString().ToLower() == "friday")
            {
                accountBalance += 500;
                Console.WriteLine("Welcome to our bank and Thank you for opening account...!");
                Console.WriteLine($"Your account balance is: {accountBalance}");
                Console.WriteLine("============================================================");
                Console.WriteLine();
            }
            else
            {
                accountBalance += 0;
                Console.WriteLine("Welcome to our bank and Thank you for opening account...!");
                Console.WriteLine($"Your account balance is: {accountBalance}");
                Console.WriteLine("============================================================");
                Console.WriteLine();
            }
        }

        public void getDetails()
        {
            Console.WriteLine($"Customer name: {this.cname}");
            Console.WriteLine( $"Account Balance: {this.accountBalance}");
            Console.WriteLine($"Accessed date and time: {DateTime.Now}");
            Console.WriteLine("============================================================");
            Console.WriteLine();
        }
        public void deposit(int amount)
        {
            if(DateTime.Now.Hour > 17 || DateTime.Now.Hour < 9)
            {
                this.status = "Failed";
                Console.WriteLine("Deposit cannot be accepted, as bank is out of office hours.");
                Console.WriteLine($"Transaction status: {this.status} and attempted date and time: {DateTime.Now}");
                Console.WriteLine("============================================================");
                Console.WriteLine();
            }

            else if(DateTime.Now.Day.ToString().ToLower() == "sunday")
            {
                this.status = "Failed";
                Console.WriteLine("Deposit cannot be accepted, as today is Sunday and bank is holiday.");
                Console.WriteLine($"Transaction status: {this.status} and attempted date and time: {DateTime.Now}");
                Console.WriteLine("============================================================");
                Console.WriteLine();
            }

            else if (amount > 50000)
            {
                this.status = "Failed";
                Console.WriteLine("Deposit cannot be accepted, as deposit amount limit is exceeded.");
                Console.WriteLine($"Transaction status: {this.status} and attempted date and time: {DateTime.Now}");
                Console.WriteLine("============================================================");
                Console.WriteLine();
            }

            else
            {
                this.status = "success";
                accountBalance += amount;
                Console.WriteLine("Deposit is accepted, as deposit made in office hours, working days and amount is less than 50000.");
                Console.WriteLine($"Available balance: {accountBalance}, Transaction status: {this.status} and attempted date and time: {DateTime.Now}");
                Console.WriteLine("============================================================");
                Console.WriteLine();
            }
        }

        public void withdraw(int amount)
        {
            if (DateTime.Now.Hour > 17 || DateTime.Now.Hour < 9)
            {
                this.status = "Failed";
                Console.WriteLine("Cannot withdraw, as bank is out of office hours.");
                Console.WriteLine($"Transaction status: {this.status} and attempted date and time: {DateTime.Now}");
                Console.WriteLine("============================================================");
                Console.WriteLine();
            }

            else if (DateTime.Now.Day.ToString().ToLower() == "sunday")
            {
                this.status = "Failed";
                Console.WriteLine("Cannot withdraw, as today is Sunday and bank is holiday.");
                Console.WriteLine($"Transaction status: {this.status} and attempted date and time: {DateTime.Now}");
                Console.WriteLine("============================================================");
                Console.WriteLine();
            }

            else if(accountBalance==0)
            {
                this.status = "Failed";
                Console.WriteLine("Cannot withdraw, as account balance is nil.");
                Console.WriteLine($"Transaction status: {this.status} and attempted date and time: {DateTime.Now}");
                Console.WriteLine("============================================================");
                Console.WriteLine();
            }

            else if (accountBalance < amount)
            {
                this.status = "Failed";
                Console.WriteLine("Cannot withdraw, as amount of shortage.");
                Console.WriteLine($"Transaction status: {this.status} and attempted date and time: {DateTime.Now}");
                Console.WriteLine("============================================================");
                Console.WriteLine();
            }

            else
            {
                this.status = "success";
                accountBalance -= amount;
                Console.WriteLine("Withdraw is successful, as withdraw made in office hours, working days and amount is available.");
                Console.WriteLine($"Available balance: {accountBalance}, Transaction status: {this.status} and attempted date and time: {DateTime.Now}");
                Console.WriteLine("============================================================");
                Console.WriteLine();
            }
        }
        
    }

    class Program34
    {
        static void Main(string[] args)
        {
            bankAccount ba1 = new bankAccount("Ramya" , 1000);
            ba1.getDetails();

            ba1.deposit(25000);
            ba1.getDetails();

            ba1.deposit(75000);
            ba1.getDetails();

            ba1.withdraw(20000);
            ba1.getDetails();

            ba1.withdraw(7000);

            ba1.withdraw(6000);
            ba1.getDetails();

            ba1.withdraw(5000);
            ba1.getDetails();

            bankAccount ba2 = new bankAccount();
            ba2.getDetails();
        }
    }
}


/*scenario: Restrict deposit and withdraw from bank acoount
 * 
 * create bank account with following members:
 * Data members: cname, accountBalance :private
 * methods: constructor(), Deposit() and withdraw()
 * 
 * implement following in constructor:
 * a. set accountbalance to 500rs when opening account on friday
 * b. set accountbalance to 0rs when opening account on other days
 * 
 * implement deposit method with following(amount as an argument):
 * a. restrict deposit out of office hours
 * b. restrict deposit on sunday
 * c. restrict deposit more than 50k
 * 
 * Note: Display attempt and status for every transaction with surrent date and time
 * 
 * implement withdraw method with following (amount as an argument)
 * a. restrict on sunday and out of working hours
 * b. restrict when funds are nil
 * c. restrict when funds are less than requested amount
 * 
 * note: display  attempt and status for every transaction with surrent date and time
 * */

/*
class Today
    {
        public static bool IsSunday()
        {
            return DateTime.Now.DayOfWeek.ToString().Substring(0, 3).ToLower() =="sun";
        }
        public static bool IsFriday()
        {
            return DateTime.Now.DayOfWeek.ToString().Substring(0, 3).ToLower() == "fri";
        }
        public static bool IsOfficeHours()
        {
            int hour = DateTime.Now.Hour;
            return (hour >= 9 && hour <= 17);
        }
    }

class BankAccount
    {
        private int accountBalance;
        private string cname;
        public BankAccount(string cname="Not Provided", int amount=0)
        {
            this.cname = cname;
            if (Today.IsFriday())
            {
                this.accountBalance = 500;
                Console.WriteLine($"Congratulations {this.cname} account opened sucessfully, you got 500rs welcome bonus");
            }
            else
            {
                this.accountBalance = 0;
                Console.WriteLine($"Congrtulations {this.cname}, account opened successfully...");
            }
             this.accountBalance += amount;
            Console.WriteLine("=========================================================");
            Thread.Sleep(3000);
        }
        public void Deposit(int amount)
        {
            Console.WriteLine($"Attempt by {this.cname}: Deposit request for {amount} at {DateTime.Now}");
            if(Today.IsSunday())
            {
                Console.WriteLine($"Status: Deposit request failed as You cannot deposit on sunday");
            }
            else if (!Today.IsOfficeHours())
            {
                Console.WriteLine($"Status: Deposit request failed as You cannot deposit out of office hours");
            }
            else if (amount > 50000)
            {
                Console.WriteLine($"Status: Deposit failed, You cannot deposit  50k above, pls check with manager");
            }
            else
            {
                this.accountBalance += amount;
                Console.WriteLine($"Status: Deposited {amount} successfully...");
            }
            Console.WriteLine("=======================================================");            
            Thread.Sleep(3000);
        }
        public void GetDetails()
        {
            Console.WriteLine($"Name: {this.cname}, Account balance: {this.accountBalance}");
        }
    }

    class Program34
    {
        static void Main(string[] args)
        {
            BankAccount c1 = new BankAccount("Kiran",5000);
            BankAccount c2 = new BankAccount();
            c1.Deposit(55000);
            c2.Deposit(12500);
        }
    }
*/