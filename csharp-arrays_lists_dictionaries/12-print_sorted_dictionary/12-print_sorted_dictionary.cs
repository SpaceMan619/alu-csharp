using System;
using System.Collections.Generic;

class Dictionary
{
	// Collect the keys, sort them alphabetically, then print in that order.
	// (SortedDictionary is disallowed, so we sort a List of keys ourselves.)
	public static void PrintSorted(System.Collections.Generic.Dictionary<string, string> myDict)
	{
		var keys = new System.Collections.Generic.List<string>();
		foreach (var entry in myDict)
			keys.Add(entry.Key);
		keys.Sort(StringComparer.Ordinal);
		foreach (var key in keys)
			Console.WriteLine("{0}: {1}", key, myDict[key]);
	}
}
