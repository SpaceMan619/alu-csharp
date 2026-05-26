using System;
class Program
{
    static void Main()
    {
        System.Globalization.CultureInfo.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        float percent = 26.41F;
        float currency = 12345.68F;
        Console.WriteLine("Percent: {0:F2}%", percent);
        Console.WriteLine("Currency: {0:C2}", currency);
    }
}
