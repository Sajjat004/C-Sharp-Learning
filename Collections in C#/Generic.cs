using System;

namespace Generic
{
    public class GenericClass<T1, T2>
    {
        public T1 Value1 { get; set; }
        public T2 Value2 { get; set; }

        public GenericClass(T1 value1, T2 value2)
        {
            Value1 = value1;
            Value2 = value2;
        }

        public void Display()
        {
            Console.WriteLine($"Value1: {Value1}, Value2: {Value2}");
        }

        public void GenericMethod<T3, T4>(T3 value3, T4 value4)
        {
            Console.WriteLine($"Value3: {value3}, Value4: {value4}");
        }
    }

    public class Test
    {
        public static void Main()
        {
            GenericClass<int, string> genericClass = new GenericClass<int, string>(10, "Hello");
            genericClass.Display();
            genericClass.GenericMethod(20, "World");
            
        }
    }
}
