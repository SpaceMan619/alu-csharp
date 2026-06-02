using System;
using System.Collections.Generic;

class Dictionary
{
	// Remove safely handles a missing key (returns false, no exception).
	public static System.Collections.Generic.Dictionary<string, string> DeleteKeyValue(
		System.Collections.Generic.Dictionary<string, string> myDict, string key)
	{
		myDict.Remove(key);
		return myDict;
	}
}
