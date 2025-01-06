using System;

namespace Test
{
    public class Destructor
    {
        public Destructor()
        {
            Console.WriteLine("Constructor is called");
        }
        ~Destructor()
        {
            Console.WriteLine("Destructor is called");
        }
    }

    public class Test
    {

        public static void Main()
        {
            Destructor d = new Destructor();
            Console.WriteLine("Object created");
            d = null;
            GC.Collect();
            Console.WriteLine("End of Main");
        }
    }
}
