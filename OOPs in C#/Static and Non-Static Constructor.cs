using System;

namespace Test
{
    public class ConstructorsDemo
    {
        public static int x; //It is going to be initialized by static constructor
        public int y; //It is going to be initialized by non-static constructor
        //Static Constructor
        static ConstructorsDemo()
        {
            //This constructor initialized the static variable x with default value i.e. 0
            Console.WriteLine("Static Constructor is Called");
        }
        //Non-Static Constructor
        public ConstructorsDemo()
        {
            //This constructor initialized the static variable y with default value i.e. 0
            Console.WriteLine("Non-Static Constructor is Called");
        }
    }
    
    public class Test
    {
        public static void Main()
        {
            Console.WriteLine("Main Method Started");
            //Before Executing the non-static constructor
            //it will first execute the static constructor of the class
            ConstructorsDemo obj1 = new ConstructorsDemo();
            //Now, onwards it will not execute the static constructor,
            //Because static constructor executed only once
            ConstructorsDemo obj2 = new ConstructorsDemo();
            ConstructorsDemo obj3 = new ConstructorsDemo();
            Console.WriteLine("Main Method Completed");
            Console.ReadKey();
        }
    }
}

