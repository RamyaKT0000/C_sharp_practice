using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    /*
    class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Parent class constructor");
        }
        public void display()
        {
            Console.WriteLine("Hello from parent class");
        }
    }

    class ChildClass : ParentClass
    {
        public ChildClass():base() //constructor overriding
        {
            Console.WriteLine("child class constructor");
        }
        public void display()
        {
            base.display(); //invoke base class method from child class
            Console.WriteLine("Hello from child class");
        }
    }
    class Program37
    {
        static void Main(string[] args)
        {
            ChildClass c1 = new ChildClass();
            c1.display();
        }
    }
    */

    /*
    class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Parent class constructor");
        }
        public virtual void display()
        {
            Console.WriteLine("Hello from parent class");
        }
    }

    class ChildClass : ParentClass
    {
        public ChildClass() : base() //constructor overriding
        {
            Console.WriteLine("child class constructor");
        }
        public override void display()
        {
            base.display(); //invoke base class method from child class
            Console.WriteLine("Hello from child class");
        }
    }
    class Program37
    {
        static void Main(string[] args)
        {
            ParentClass c1;
            c1 = new ParentClass();

            c1.display();

            c1 = new ChildClass();

            c1.display();
        }
    }*/

    class ParentClass
    {
        protected string name;
        protected int age;

        public ParentClass(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public virtual void display()
        {
            Console.WriteLine($"parent name: {name} and age: {age}");
        }
    }

    class ChildClass : ParentClass
    {
        public ChildClass(string name, int age) : base(name, age) //constructor overriding
        {
            
        }
        public override void display()
        { 
            Console.WriteLine($"child name: {name} and age: {age}");
        }
    }
    class Program37
    {
        static void Main(string[] args)
        {
            ParentClass c1;
            c1 = new ParentClass("Chaitra", 43);

            c1.display();

            Console.WriteLine("===============================================");

            c1 = new ChildClass("Ramya", 21);

            c1.display();

            Console.WriteLine("===============================================");
        }
    }

}
/*
 * Virtual method
 * 
 * When the object declared for base class and memory allocated to derived , 
 * the base class method override even memory refers to child class
 * 
 * to overcome prefix virtual to the base class method and override in child class
 */