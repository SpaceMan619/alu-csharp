using System;
using System.Collections.Generic;

class Dictionary
{
	// Indexer assignment adds the key if missing, or replaces the value if present.
	public static System.Collections.Generic.Dictionary<string, string> AddKeyValue(
		System.Collections.Generic.Dictionary<string, string> myDict, string key, string value)
	{
		myDict[key] = value;
		return myDict;
	}
}
