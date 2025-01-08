using System;

namespace Test
{
    public delegate void RectangleDelegate(double Width, double Height);
    public class Rectangle
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine($"Area is {Width * Height}");
        }
        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine($"Perimeter is {2 * (Width + Height)}");
        }
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            RectangleDelegate rectDelegate = new RectangleDelegate(rect.GetArea);
            // RectangleDelegate rectDelegate = rect.GetArea;
            // binding a method with delegate object
            // In this example rectDelegate is a multicast delegate. 
            // You use += operator to chain delegates together.
            rectDelegate += rect.GetPerimeter;
            Delegate[] InvocationList = rectDelegate.GetInvocationList();
            Console.WriteLine("InvocationList:");
            foreach (var item in InvocationList)
            {
                Console.WriteLine($"  {item}");
            }
            Console.WriteLine();
            Console.WriteLine("Invoking Multicast Delegate:");
            rectDelegate(23.45, 67.89);
            //rectDelegate.Invoke(13.45, 76.89);
            
            Console.WriteLine();
            Console.WriteLine("Invoking Multicast Delegate After Removing one Pipeline:");
            //Removing a method from delegate object
            rectDelegate -= rect.GetPerimeter;
            rectDelegate.Invoke(13.45, 76.89);
            Console.ReadKey();
        }
    }
}