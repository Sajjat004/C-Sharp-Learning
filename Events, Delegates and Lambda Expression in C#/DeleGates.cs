using System;

namespace Test
{
    public delegate void MyDelegate(string message);

    public class Work
    {
        public void Process(MyDelegate del)
        {
            Console.WriteLine("Processing some Task");
            
            del("Process() begin");
            del("Process() end");
        }

        public static void DoWork(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class Test
    {
        public static void Main()
        {
            Work work = new Work();
            MyDelegate del = new MyDelegate(Work.DoWork);
            work.Process(del);
        }
    }
}