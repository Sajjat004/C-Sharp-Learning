using System;

namespace Test
{
    public interface I1
    {
        void Method1();
        void TestMethod();
        void TestMethod2();
    }

    public interface I2
    {
        void TestMethod();
        void Method2();
        void TestMethod2();
    }

    public class A : I1, I2
    {
        public void Method1()
        {
            Console.WriteLine("Method1");
        }

        public void Method2()
        {
            Console.WriteLine("Method2");
        }

        public void TestMethod()
        {
            Console.WriteLine("TestMethod");
        }

        void I1.TestMethod2()
        {
            Console.WriteLine("I1 TestMethod2");
        }

        void I2.TestMethod2()
        {
            Console.WriteLine("I2 TestMethod2");
        }
    }

    public class Test
    {
        public static void Main()
        {
            A a = new A();
            a.Method1();
            a.Method2();
            a.TestMethod();
            ((I1)a).TestMethod2();
            ((I2)a).TestMethod2();
        }
    }
}