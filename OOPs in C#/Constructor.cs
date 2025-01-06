using System;

namespace Test
{
    // Defining class or blueprint or template
    public class Calculator
    {
        // Defining constructor
        public Calculator()
        {
            Console.WriteLine("Constructor is called");
        }

        public int CalculateSum(int a, int b)
        {
            return a + b;
        }
    }

    // static constructor
    public class StaticConstructor
    {
        // Defining static constructor
        static StaticConstructor()
        {
            Console.WriteLine("Static constructor is called");
        }

        public void Display()
        {
            Console.WriteLine("Display method is called");
        }
    }

    public class Test
    {
        private Test()
        {
            Console.WriteLine("This is private constructor");
        }

        public static void Main()
        {
            // Creating object of class
            Calculator obj = new Calculator();
            // Accessing method using object
            int result = obj.CalculateSum(10, 20);
            Console.WriteLine("Sum is: " + result);

            // Creating object of class
            StaticConstructor obj1 = new StaticConstructor();
            // Accessing method using object
            obj1.Display();

            // Creating object of class
            Test obj2 = new Test();

        }
    }
}




