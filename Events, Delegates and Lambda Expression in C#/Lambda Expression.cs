using System;

public class Test
{
    public delegate string GreetingsDelegate(string name);

	public static void Main()
	{
		GreetingsDelegate obj = (name) =>
        {
            return "Hello @" + name + " welcome to Dotnet Tutorials";
        };
        string GreetingsMessage = obj.Invoke("Pranaya");
        Console.WriteLine(GreetingsMessage);
    }
}
