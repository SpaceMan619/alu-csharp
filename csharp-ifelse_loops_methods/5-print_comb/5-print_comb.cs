using System;

class Program
{
	static void Main(string[] args)
	{
		for (int i = 0; i <= 99; i++)
			Console.Write("{0:D2}{1}", i, i < 99 ? ", " : "\n");
	}
}
