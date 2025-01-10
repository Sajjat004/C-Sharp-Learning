using System;
using System.Collections.Generic;

public class Test
{
	public static void Main()
	{
		List<string> list = new List<string>();
        list.Add("Hello, World!");
        list.Add("Hello, C#!");
        list.Add("Hello, Collections!");

        // Accessing generic list elements using foreach loop
        Console.WriteLine("Accessing generic list elements using foreach loop");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        // Accessing generic list elements using for loop
        Console.WriteLine("Accessing generic list elements using for loop");
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }

        // Accessing List elements using the index of the element
        Console.WriteLine("Accessing List elements using the index of the element");
        Console.WriteLine(list[0]);
        Console.WriteLine(list[1]);
        Console.WriteLine(list[2]);

        // changing the value of an element
        Console.WriteLine("changing the value of an element");
        list[2] = "Hello!";

        // Checking if the list contains a specific element
        Console.WriteLine("Checking if the list contains a specific element");
        Console.WriteLine(list.Contains("Hello, World!"));
        Console.WriteLine(list.Contains("Hello, C#!"));
        Console.WriteLine(list.Contains("Hello"));

        // Removing an element from the list
        Console.WriteLine("Removing an element from the list");
        list.Remove("Hello, C#!");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        // Sorting the list
        Console.WriteLine("Sorting the list");
        list.Sort();
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        // Clearing the list
        Console.WriteLine("Clearing the list");
        list.Clear();
        Console.WriteLine(list.Count);
	}
}
