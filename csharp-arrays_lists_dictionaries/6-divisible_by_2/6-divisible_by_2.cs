using System;
using System.Collections.Generic;

class List
{
	public static System.Collections.Generic.List<bool> DivisibleBy2(System.Collections.Generic.List<int> myList)
	{
		var result = new System.Collections.Generic.List<bool>();
		foreach (int n in myList)
			result.Add(n % 2 == 0);
		return result;
	}
}
