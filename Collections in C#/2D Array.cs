using System;

public class Test
{
	public static void Main()
	{
		int[,] arr = new int[5, 7];

        for (int i = 0; i < arr.GetLength(0); ++i) {
            for (int j = 0; j < arr.GetLength(1); ++j) {
                arr[i, j] = i + j;
            }
        }

        foreach (var x in arr) {
            Console.Write(x + " ");
        }
        Console.WriteLine();

        int[][] arr2 = new int[5][];
        for (int i = 0; i < arr2.Length; ++i) {
            arr2[i] = new int[7];
            for (int j = 0; j < arr2[i].Length; ++j) {
                arr2[i][j] = i + j;
            }
        }

        foreach (var x in arr2) {
            foreach (var y in x) {
                Console.Write(y + " ");
            }
            Console.WriteLine();
        }
	}
}
