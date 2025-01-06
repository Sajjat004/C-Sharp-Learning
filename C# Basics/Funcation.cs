using System;

public class Test
{
    private int Add(int a, int b)
    {
        return a + b;
    }

    private int Add(int a, int b, int c)
    {
        return a + b + c;
    }

	public static void Main()
	{
        Test obj = new Test();
        Console.WriteLine("Addition of two numbers : " + obj.Add(10, 20));
        Console.WriteLine("Addition of three numbers : " + obj.Add(10, 20, 30));
	}
}
