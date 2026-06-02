using System;
using System.Collections.Generic;

class Dictionary
{
	// Counts keys by iterating, since .Count() (the LINQ method) is not allowed.
	public static int NumberOfKeys(System.Collections.Generic.Dictionary<string, string> myDict)
	{
		int total = 0;
		foreach (var key in myDict.Keys)
			total++;
		return total;
	}
}
