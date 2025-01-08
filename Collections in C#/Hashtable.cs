using System;
using System.Collections;

public class Test
{
	public static void Main()
	{
        Hashtable hashtable = new Hashtable();
        //Adding elements to the Hash table using key value pair
        hashtable.Add("EId", 1001); //Here key is Eid and value is 1001
        hashtable.Add("Name", "James"); //Here key is Name and value is James
        hashtable.Add("Salary", 3500); //Here key is Salary and value is 3500
        hashtable.Add("Location", "Mumbai"); //Here key is Location and value is Mumbai
        hashtable.Add("EmailID", "a@a.com"); //Here key is EmailID and value is a@a.com

        //Displaying the elements of the Hash table
        foreach (DictionaryEntry de in hashtable)
        {
            Console.WriteLine("Key: {0} and Value: {1}", de.Key, de.Value);
        }
        Console.WriteLine();

        // Displaying the value of the key "Name"
        Console.WriteLine("Value of the key Name is: " + hashtable["Name"]);
        Console.WriteLine();

        // Checking whether the key "Location" is present in the Hash table or not
        if (hashtable.Contains("Location"))
        {
            Console.WriteLine("Key Location is present in the Hash table");
        }
        else
        {
            Console.WriteLine("Key Location is not present in the Hash table");
        }
        Console.WriteLine();

        // Changing the value of the key "Salary"
        hashtable["Salary"] = 4000;

        //Removing the element from the Hash table
        hashtable.Remove("Location");

        //Displaying the elements of the Hash table after removing the element
        foreach (DictionaryEntry de in hashtable)
        {
            Console.WriteLine("Key: {0} and Value: {1}", de.Key, de.Value);
        }
        Console.WriteLine();

        //Removes all elements
        hashtable.Clear();
        Console.WriteLine($"After cleaning hashtable total elements: {hashtable.Count}");

    }
}
