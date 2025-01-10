using System;
using System.Collections.Generic;

public class Test
{
    public static void Main()
    {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(4);

        // Size of the queue
        Console.WriteLine("Size of the queue: " + queue.Count);

        // Accessing generic queue elements using foreach loop
        Console.WriteLine("Accessing generic queue elements using foreach loop");
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }
        
        // Removing and Returning an Element from the Generic Queue using Dequeue method
        Console.WriteLine($"\nDeleted Element: {queue.Dequeue()}");

        // Printing elements of the queue after removing an element
        Console.WriteLine("Printing elements of the queue after removing an element");
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }

        // Checking if the queue contains a specific element
        Console.WriteLine("Checking if the queue contains a specific element");
        Console.WriteLine(queue.Contains(3));

        // Returning the first element of the queue without removing it
        Console.WriteLine("Returning the first element of the queue without removing it");
        Console.WriteLine(queue.Peek());

        // Clearing the queue
        Console.WriteLine("Clearing the queue");
        queue.Clear();
        Console.WriteLine("Size of the queue: " + queue.Count);
    }
}