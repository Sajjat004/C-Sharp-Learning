using System;

namespace Test
{
    public interface ITestInterface1
    {
        void Add(int a, int b);
    }
    public interface ITestInterface2 : ITestInterface1
    {
        void Sub(int a, int b);
    }

    public class ImplementationClass1 : ITestInterface1
    {
        public void Add(int a, int b)
        {
            Console.WriteLine($"Addition of {a} and {b} is {a + b}");
        }
    }

    public class ImplementationClass2 : ITestInterface2
    {
        public void Add(int a, int b)
        {
            Console.WriteLine($"Addition of {a} and {b} is {a + b}");
        }

        public void Sub(int a, int b)
        {
            Console.WriteLine($"Subtraction of {a} and {b} is {a - b}");
        }
    }

    public class Test
    {
        public static void Main()
        {
            ITestInterface1 obj1 = new ImplementationClass1();
            obj1.Add(10, 20);

            ITestInterface2 obj2 = new ImplementationClass2();
            obj2.Add(10, 20);
            obj2.Sub(20, 10);
        }
    }
}

