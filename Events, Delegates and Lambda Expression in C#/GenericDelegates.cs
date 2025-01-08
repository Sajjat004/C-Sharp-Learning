using System;

namespace Test
{
    public class Test
    {
        public static void Main()
        {
            Func<int, float, double, double> obj1 = new Func<int, float, double, double>(AddNumber1);
            Console.WriteLine(obj1(10, 20.5f, 30.5));

            Action<int, float, double> obj2 = new Action<int, float, double>(AddNumber2);
            obj2(10, 20.5f, 30.5);

            Predicate<string> obj3 = new Predicate<string>(CheckLength);
            Console.WriteLine(obj3("Hello World"));
        }

        public static double AddNumber1(int no1, float no2, double no3)
        {
            return no1 + no2 + no3;
        }

        public static void AddNumber2(int no1, float no2, double no3)
        {
            Console.WriteLine(no1 + no2 + no3);
        }

        public static bool CheckLength(string name)
        {
            if (name.Length > 5) return true;
            return false;
        } 
    }
}