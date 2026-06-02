using System;
using System.Collections.Generic;

class Dictionary
{
	// Counts keys by iterating, since .Count() (the LINQ method) is not allowed.
	public static int NumberOfKeys(System.Collections.Generic.Dictionary<string, string> myDict)
	{
		int count = 0;
		foreach (var entry in myDict)
			count++;
		return count;
	}
}
