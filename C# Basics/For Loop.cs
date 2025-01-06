using System;

public class Test
{
	public static void Main()
	{
		Console.Write("Enter one Integer Number:");
        int number = Convert.ToInt32(Console.ReadLine());
        for (int counter = 1; counter <= number; counter++)
        {
            Console.WriteLine(counter);
        }
    }
}
