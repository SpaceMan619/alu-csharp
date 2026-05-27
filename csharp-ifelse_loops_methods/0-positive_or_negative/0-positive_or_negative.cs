using System;

class Program
{
	static void Main(string[] args)
	{
		int number = new Random().Next(-10, 11);
		if (number > 0)
			Console.WriteLine("{0} is positive", number);
		else if (number == 0)
			Console.WriteLine("{0} is zero", number);
		else
			Console.WriteLine("{0} is negative", number);
	}
}
