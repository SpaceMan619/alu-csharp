using System;
using System.Globalization;
class Program
{
    static void Main()
    {
        float number = 3.14159F;
        Console.WriteLine("Float: {0}", number.ToString("F2", CultureInfo.InvariantCulture));
    }
}
