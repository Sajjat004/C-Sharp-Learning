using System;

public class Test
{
    public delegate string GreetingsDelegate(string name);

	public static void Main()
	{
		string Message = "Welcome to Dotnet Tutorials";
        GreetingsDelegate gd = delegate (string name)
        {
            return "Hello @" + name + " " + Message;
        };
        string GreetingsMessage = gd.Invoke("Pranaya");
        Console.WriteLine(GreetingsMessage);
	}
}
