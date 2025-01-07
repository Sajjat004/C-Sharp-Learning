using System;

namespace Test
{
    public class Class1
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Sum of two integers: " + (a + b));
        }

        public void Add(float a, float b)
        {
            Console.WriteLine("Sum of two floats: " + (a + b));
        }
    }

    public class Class2 : Class1
    {
        public void Add(string a, string b)
        {
            Console.WriteLine("Concatenation of two strings: " + a + " " + b);
        }
    }

    public class Test
    {
        public static void Main()
        {
            Class2 obj = new Class2();
            obj.Add(10, 20);
            obj.Add(10.5f, 20.5f);
            obj.Add("Hello", "World");
        }
    }
}

// Node: Method Overloading is also known as Compile-time Polymorphism.