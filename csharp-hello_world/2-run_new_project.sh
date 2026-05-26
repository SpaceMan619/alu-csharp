#!/usr/bin/env bash
dotnet new console -o 2-new_project
echo 'using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }
}' > 2-new_project/Program.cs
dotnet run --project 2-new_project
