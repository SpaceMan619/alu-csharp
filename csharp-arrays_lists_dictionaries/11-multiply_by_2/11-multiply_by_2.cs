using System;
using System.Collections.Generic;

class Dictionary
{
	// Builds a brand-new dictionary so the original is left unchanged.
	public static System.Collections.Generic.Dictionary<string, int> MultiplyBy2(
		System.Collections.Generic.Dictionary<string, int> myDict)
	{
		var newDict = new System.Collections.Generic.Dictionary<string, int>();
		foreach (var entry in myDict)
			newDict[entry.Key] = entry.Value * 2;
		return newDict;
	}
}
