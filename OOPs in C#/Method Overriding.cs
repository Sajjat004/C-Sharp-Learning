using System;

namespace Test
{
    public class Class1
    {
        public virtual void Show()
        {
            Console.WriteLine("Parent Class Show Method");
        }

        public void Display()
        {
            Console.WriteLine("Parent Class Display Method");
        }
    }

    public class Class2 : Class1
    {
        public override void Show()
        {
            Console.WriteLine("Child Class Show Method");
        }
    }

    public class Test
    {
        public static void Main()
        {
            Class2 obj = new Class2();
            obj.Show();
            obj.Display();

            Class1 obj1 = new Class1();
            obj1.Show();
            obj1.Display();
        }
    }
}

// Note: Method Overriding is also known as Run-time Polymorphism.