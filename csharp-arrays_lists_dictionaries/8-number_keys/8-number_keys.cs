using System;
using System.Collections.Generic;

class Dictionary
{
	// Tally the keys by iterating, since the LINQ tallying method is not allowed.
	public static int NumberOfKeys(System.Collections.Generic.Dictionary<string, string> myDict)
	{
		int total = 0;
		foreach (var key in myDict.Keys)
			total++;
		return total;
	}
}
