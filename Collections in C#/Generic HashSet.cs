using System;
using System.Collections.Generic;

public class Test
{
    public static void Main()
    {
        HashSet<int> hashSet = new HashSet<int>();
        hashSet.Add(1);
        hashSet.Add(2);
        hashSet.Add(3);
        hashSet.Add(4);
        // Adding duplicate elements will not be added to the hash set
        hashSet.Add(4);
        hashSet.Add(5);
        hashSet.Add(6);
        hashSet.Add(7);

        // Size of the hash set
        Console.WriteLine("Size of the hash set: " + hashSet.Count);

        // Accessing generic hash set elements using foreach loop
        Console.WriteLine("Accessing generic hash set elements using foreach loop");
        foreach (var item in hashSet)
        {
            Console.WriteLine(item);
        }
        
        // Removing an element from the Generic Hash Set using Remove method
        Console.WriteLine("\nRemoving an element from the Generic Hash Set using Remove method");
        hashSet.Remove(3);

        // Printing elements of the hash set after removing an element
        Console.WriteLine("Printing elements of the hash set after removing an element");
        foreach (var item in hashSet)
        {
            Console.WriteLine(item);
        }

        // Removing all the elements that satisfy the condition
        hashSet.RemoveWhere(x => x % 2 == 0);
        Console.WriteLine("\nRemoving all the elements that satisfy the condition");
        foreach (var item in hashSet)
        {
            Console.WriteLine(item);
        }

        // Checking if the hash set contains a specific element
        Console.WriteLine("Checking if the hash set contains a specific element");
        Console.WriteLine(hashSet.Contains(3));

        // Clearing the hash set
        Console.WriteLine("Clearing the hash set");
        hashSet.Clear();
        Console.WriteLine("Size of the hash set: " + hashSet.Count);

        // hashSet union
        HashSet<int> hashSet1 = new HashSet<int> { 1, 2, 3, 4, 5 };
        HashSet<int> hashSet2 = new HashSet<int> { 4, 5, 6, 7, 8 };
        hashSet1.UnionWith(hashSet2);
        Console.WriteLine("\nUnion of hashSet1 and hashSet2");
        foreach (var item in hashSet1)
        {
            Console.WriteLine(item);
        }

        // hashSet intersection
        hashSet1.IntersectWith(hashSet2);
        Console.WriteLine("\nIntersection of hashSet1 and hashSet2");
        foreach (var item in hashSet1)
        {
            Console.WriteLine(item);
        }

        // hashSet difference
        hashSet1.ExceptWith(hashSet2);
        Console.WriteLine("\nDifference of hashSet1 and hashSet2");
        foreach (var item in hashSet1)
        {
            Console.WriteLine(item);
        }

        // hashSet symmetric difference
        hashSet1.SymmetricExceptWith(hashSet2);
        Console.WriteLine("\nSymmetric difference of hashSet1 and hashSet2");
        foreach (var item in hashSet1)
        {
            Console.WriteLine(item);
        }
    }
}