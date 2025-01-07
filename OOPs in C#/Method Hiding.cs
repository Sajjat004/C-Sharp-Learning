using System;

namespace Test
{
    public class Parent
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
    public class Child : Parent
    {
        //Method Overriding
        public override void Show()
        {
            Console.WriteLine("Child Class Show Method");
        }
        //Method Hiding/Shadowing
        public new void Display()
        {
            Console.WriteLine("Child Class Display Method");
        }
    }

    public class Test
    {
        public static void Main()
        {
            Child obj = new Child();
            obj.Show();
            obj.Display();

            Parent obj1 = new Parent();
            obj1.Show();
            obj1.Display();
        }
    }
}