using System;

namespace Test
{
    // Defining class or blueprint or template
    public class Calculator
    {
        public int CalculateSum(int a, int b)
        {
            return a + b;
        }
    }
    public class Test
    {
        public static void Main()
        {
            // Creating object of class
            Calculator obj = new Calculator();
            // Accessing method using object
            int result = obj.CalculateSum(10, 20);
            Console.WriteLine("Sum is: " + result);
        }
    }
}

