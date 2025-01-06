using System;

public class Test
{
	public static void Main()
	{
	    // Implicit Conversion
		int numInt = 1500;
		double numDouble = numInt;

        Console.WriteLine($"numInt: {numInt}");
        Console.WriteLine($"numDouble: {numDouble}");

        // Explicit Conversion
        double numDouble2 = 1500.5;
        int numInt2 = (int)numDouble2;

        Console.WriteLine($"numDouble2: {numDouble2}");
        Console.WriteLine($"numInt2: {numInt2}");
	}
}

// Note: The type casting is also can be done by using Convert class and Parse method. Bellow are the examples:
/*
int numInt = 1500;
double numDouble = Convert.ToDouble(numInt);
double numDouble = double.Parse(numInt.ToString());

string numString = "1500";
int numInt = Convert.ToInt32(numString);
int numInt = int.Parse(numString);
bool isParsed = int.TryParse(numString, out int numInt); // TryParse method returns a boolean value to indicate whether the conversion succeeded or failed. If the conversion is successful, the out parameter will contain the converted value. Otherwise, it will contain the default value for the target type.
*/
