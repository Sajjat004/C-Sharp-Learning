using System;
using System.Collections.Generic;

public class Test
{
    public static void Main()
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>();

        // Adding key-value pairs in the dictionary
        dictionary.Add(1, "One");
        dictionary.Add(2, "Two");
        dictionary.Add(3, "Three");
        dictionary.Add(4, "Four");
        dictionary.Add(5, "Five");

        // Size of the dictionary
        Console.WriteLine("Size of the dictionary: " + dictionary.Count);

        // Accessing generic dictionary elements using foreach loop
        Console.WriteLine("Accessing generic dictionary elements using foreach loop");
        foreach (var item in dictionary) // item is KeyValuePair<int, string> and we can also use KeyValuePair<int, string> instead of var
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }

        // Removing an element from the Generic Dictionary using Remove method
        Console.WriteLine("\nRemoving an element from the Generic Dictionary using Remove method");
        dictionary.Remove(3);

        // Printing elements of the dictionary after removing an element
        Console.WriteLine("Printing elements of the dictionary after removing an element");
        foreach (var item in dictionary)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }

        // Checking if the dictionary contains a specific key
        Console.WriteLine("Checking if the dictionary contains a specific key");
        Console.WriteLine(dictionary.ContainsKey(2));

        // Checking if the dictionary contains a specific value
        Console.WriteLine("Checking if the dictionary contains a specific value");
        Console.WriteLine(dictionary.ContainsValue("Five"));

        // Assign values to the dictionary using indexer
        Console.WriteLine("Assign values to the dictionary using indexer");
        dictionary[4] = "Four (Updated)";
        dictionary[6] = "Six";
        foreach (var item in dictionary)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }

        // Clearing the dictionary
        Console.WriteLine("Clearing the dictionary");
        dictionary.Clear();
        Console.WriteLine("Size of the dictionary: " + dictionary.Count);
    }
}