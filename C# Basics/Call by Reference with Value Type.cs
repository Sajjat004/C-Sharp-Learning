using System;

public class Test
{
    public static void CallByReference(ref int x)
    {
        x = 20;
        Console.WriteLine("Inside the method x = " + x);
    }

	public static void Main()
	{
        int x = 10;
        Console.WriteLine("Before calling the method x = " + x);
        CallByReference(ref x);
        Console.WriteLine("After calling the method x = " + x);
	}
}
