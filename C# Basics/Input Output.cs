using System;

public class Test
{
	public static void Main()
	{
		Console.WriteLine("Enter two numbers:");
		
		int number1 = Convert.ToInt32(Console.ReadLine());
		int number2 = Convert.ToInt32(Console.ReadLine());
		int result = number1 + number2;
		
		Console.WriteLine($"The sum of {number1} and {number2} is: {result}");
	}
}
