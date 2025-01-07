using System;

namespace Test
{
    public class Complex
    {
        private int _real;
        private int _imaginary;

        public Complex(int real, int imaginary)
        {
            _real = real;
            _imaginary = imaginary;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1._real + c2._real, c1._imaginary + c2._imaginary);
        }

        public void Display()
        {
            Console.WriteLine($"{_real} + {_imaginary}i");
        }
    }

    public class Test
    {
        public static void Main()
        {
            Complex c1 = new Complex(2, 3);
            Complex c2 = new Complex(3, 4);
            Complex c3 = c1 + c2;

            c1.Display();
            c2.Display();
            c3.Display();
        }
    }
}

// Node: Method Overloading is also known as Compile-time Polymorphism.