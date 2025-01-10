using System;
using System.Collections.Generic;

public class Test
{
    public static void Main()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(4);

        // Size of the stack
        Console.WriteLine("Size of the stack: " + stack.Count);

        // Accessing generic stack elements using foreach loop
        Console.WriteLine("Accessing generic stack elements using foreach loop");
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
        
        // Removing and Returning an Element from the Generic Stack using Pop method
        Console.WriteLine($"\nDeleted Element: {stack.Pop()}");

        // Printing elements of the stack after removing an element
        Console.WriteLine("Printing elements of the stack after removing an element");
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }

        // Checking if the stack contains a specific element
        Console.WriteLine("Checking if the stack contains a specific element");
        Console.WriteLine(stack.Contains(3));

        // Returning the top element of the stack without removing it
        Console.WriteLine("Returning the top element of the stack without removing it");
        Console.WriteLine(stack.Peek());

        // Clearing the stack
        Console.WriteLine("Clearing the stack");
        stack.Clear();
        Console.WriteLine("Size of the stack: " + stack.Count);
    }
}