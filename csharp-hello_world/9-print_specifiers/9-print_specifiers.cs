using System;
using System.Globalization;
class Program
{
    static void Main()
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US");
        float percent = 75.53F;
        float currency = 98765.43F;
        Console.WriteLine("Percent: {0:F2}%", percent);
        Console.WriteLine("Currency: {0:C2}", currency);
    }
}
