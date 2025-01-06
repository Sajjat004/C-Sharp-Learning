using System;

public class Test
{
    public const int x = 10;
    public readonly int y;

    public Test()
    {
        y = 30;
    }

	public static void Main()
	{
        // Constant
        Test obj = new Test();
        // obj.x = 20; // Error: A constant value cannot be changed
        Console.WriteLine("Value of x: " + x);

        // Readonly
        // obj.y = 30; // Error: A readonly field cannot be assigned to (except in a constructor or a variable initializer)
        Console.WriteLine("Value of y: " + obj.y);

	}
}
