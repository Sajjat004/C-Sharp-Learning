using System;

public class Test
{
	public static void Main()
	{
		// Descimal literal
        int a = 101;
        Console.WriteLine($"Decimal Literal: {a}");

        // Hexadecimal literal
        int b = 0x123f;
        Console.WriteLine($"Hexadecimal Literal: {b}");

        // Binary literal
        int c = 0b1011;
        Console.WriteLine($"Binary Literal: {c}");

        // Integer literal
        int d = 123;
        Console.WriteLine($"Integer Literal: {d}");

        // Unsigned integer literal
        uint e = 123u;
        Console.WriteLine($"Unsigned Integer Literal: {e}");

        // Long literal
        long f = 123L;
        Console.WriteLine($"Long Literal: {f}");

        // Unsigned long literal
        ulong g = 123ul;
        Console.WriteLine($"Unsigned Long Literal: {g}");

        // Float literal
        float h = 123.45f;
        Console.WriteLine($"Float Literal: {h}");

        // Double literal
        double i = 123.45;
        Console.WriteLine($"Double Literal: {i}");

        // Decimal literal
        decimal j = 123.45m;
        Console.WriteLine($"Decimal Literal: {j}");

        // Character literal
        char k = 'A';
        Console.WriteLine($"Character Literal: {k}");

        // String literal
        string str1 = "Dot Net Tutorials";
        string str2 = @"Dot Net Tutorials";
        string str3 = "Dot\nNet\tTutorials";
        string str4 = @"Dot\nNet\tTutorials";
        Console.WriteLine($"String Literal: {str1}");
        Console.WriteLine($"String Literal: {str2}");
        Console.WriteLine($"String Literal: {str3}");
        Console.WriteLine($"String Literal: {str4}");

        // Boolean literal
        bool l = true;
        bool m = false;
        Console.WriteLine($"Boolean Literal: {l}");
        Console.WriteLine($"Boolean Literal: {m}");
	}
}
