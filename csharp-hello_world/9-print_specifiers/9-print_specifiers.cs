using System;
class Program
{
	static void Main(string[] args)
	{
		double percent = .7553;
		double currency = 98765.4321;
		System.Globalization.CultureInfo.CurrentCulture = new System.Globalization.CultureInfo("en-US");
		Console.WriteLine("Percent: {0:F2}%", percent * 100);
		Console.WriteLine("Currency: {0:C2}", currency);
	}
}
