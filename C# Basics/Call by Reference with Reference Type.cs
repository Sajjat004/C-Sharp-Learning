using System;

public class Test
{
    public static void CallByReference(ref int[] arr)
    {
        arr[0] = 20;
        Console.WriteLine("Inside the method arr[0] = " + arr[0]);
    }

	public static void Main()
	{
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Before calling the method arr[0] = " + arr[0]);
        CallByReference(ref arr);
        Console.WriteLine("After calling the method arr[0] = " + arr[0]);
	}
}
