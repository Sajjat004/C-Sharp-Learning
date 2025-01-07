using System;

namespace Test
{
    public class Printer
    {
        //The Printer class declaring two virtual methods
        public virtual void Display()
        {
            Console.WriteLine("Display Dimension: 5x5");
        }
        public virtual void Print()
        {
            Console.WriteLine("Printer Printing...\n");
        }
    }
    public class LaserJet : Printer
    {
        //The LaserJet class Overriding the two parent class virtal methods
        //But making the Display method as sealed, so the child classes of LaserJet class
        //will not override this method
        public sealed override void Display()
        {
            Console.WriteLine("Display Dimension: 10x10");
        }
        //The Print method can be override under the Child class of LaserJet class
        public override void Print()
        {
            Console.WriteLine("LaserJet Printer Printing...\n");
        }
    }
    //The InkJet class can not override the Display Method as it is marked sealed in LaserJet class.
    //So, InkJet will have same Display feature i.e it also has "Display Dimention: 10x10".
    public sealed class InkJet : LaserJet
    {
        //The following method overriding will give compile time error
        //'InkJet.Display()': cannot override inherited member 'LaserJet.Display()' because it is sealed
        //public override void Display()
        //{
        //    Console.WriteLine("Some Different Display Dimension");
        //}
        public override void Print()
        {
            Console.WriteLine("InkJet Printer Printing...");
        }
    }
    //As we marked the InkJet class as sealed so more inheritance using InkJet class
    //The following inheritance will give you compile time error
    //'DotMatrix': cannot derive from sealed type 'InkJet'
    //class DotMatrix : InkJet
    //{
    //}
    
    public class Test
    {
        public static void Main()
        {
            // your code goes here
        }
    }
}