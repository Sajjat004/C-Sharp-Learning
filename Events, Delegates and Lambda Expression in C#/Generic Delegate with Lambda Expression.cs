using System;

namespace Test
{
    public class Test
    {
        public static void Main()
        {
            Func<int, float, double, double> obj1 = (x, y, z) =>
            {
                return x + y + z;
            };

            Console.WriteLine(obj1(10, 20.5f, 30.5));

            Action<int, float, double> obj2 = (x, y, z) =>
            {
                Console.WriteLine(x + y + z);
            };
            obj2(10, 20.5f, 30.5);

            Predicate<string> obj3 = (name) =>
            {
                if (name.Length > 5) return true;
                return false;
            };
            Console.WriteLine(obj3("Hello World"));
        }
    }
}