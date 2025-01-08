using System;

public class Test
{
	public static void Main()
	{
		int[] arr = new int[10];

        for (int i = 0; i < arr.Length; ++i) {
            arr[i] = i + 1;
        }

        foreach (var x in arr) {
            Console.WriteLine(x);
        }
	}
}
