using System;

public class Test
{
	public static void Main()
	{
        Console.Write("Enter a Number : ");
        int n = Convert.ToInt32(Console.ReadLine());
        int i = 2;
        while (i <= n)
        {
            if (i == 4)
            {
                i++;
                continue;
            }
            if (i == 6)
            {
                break;
            }
            Console.Write($"{i} ");
            i = i + 2;
        }
	}
}
