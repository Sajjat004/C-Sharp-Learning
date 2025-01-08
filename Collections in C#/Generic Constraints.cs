using System;

namespace Test
{
    public class GenericConstraints<T> where T : class
    {
        public T Value { get; set; }

        public GenericConstraints(T value)
        {
            Value = value;
        }

        public void Print()
        {
            Console.WriteLine(Value);
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public string Location { get; set; }
    }

    public class Test
    {
        public static void Main()
        {
            GenericConstraints<string> genericConstraints = new GenericConstraints<string>("Hello, World!");
            genericConstraints.Print();

            GenericConstraints<Employee> genericConstraints1 = new GenericConstraints<Employee>(new Employee { Name = "John Doe", Location = "New York" });
            genericConstraints1.Print();

            // This will not compile
            // GenericConstraints<int> genericConstraints2 = new GenericConstraints<int>(5);
            // genericConstraints2.Print();


        }
    }
}