using System;

namespace Test
{
    public class Test
    {
        public static void Main()
        {
            B obj = new B(10);
            obj.MethodA1();
            obj.MethodA2();
            obj.MethodB1();
        }
    }

    public class A
    {
        public A(int number)
        {
            Console.WriteLine("A's constructor is called with number = " + number);
        }

        public void MethodA1()
        {
            Console.WriteLine("MethodA1 is called");
        }

        public void MethodA2()
        {
            Console.WriteLine("MethodA2 is called");
        }
    }

    public class B : A
    {
        public B(int number) : base(number)
        {
            Console.WriteLine("B's constructor is called with number = " + number);
        }

        public void MethodB1()
        {
            Console.WriteLine("MethodB1 is called");
        }
    }
}

/*
Types of Inheritance
Single Inheritance: When a class is inherited from a single base class then the inheritance is called single inheritance.
Multilevel Inheritance: When a derived class is created from another derived class, then such a type of inheritance is called Multilevel Inheritance.
Hierarchical Inheritance: When more than one derived class is created from a single base class then it is called Hierarchical inheritance.
Multiple Inheritance: When a derived class is created from more than one base class then such type of inheritance is called multiple inheritances.
Hybrid Inheritance: Hybrid Inheritance is the inheritance that is the combination of any Single, Hierarchical, and Multilevel inheritances.
*/

