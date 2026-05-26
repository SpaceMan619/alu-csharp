using System;

class Program
{
    static void Main()
    {
        string str1 = "object-oriented programming in a multilingual puzzle";
        string str2 = "C# Sharp";
        Console.WriteLine(str1.Substring(0, 27) + str1.Substring(27, 4) + str2.Substring(0, 2));
    }
}
