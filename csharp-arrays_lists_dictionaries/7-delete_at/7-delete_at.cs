using System;
using System.Collections.Generic;

class List
{
	public static System.Collections.Generic.List<int> DeleteAt(System.Collections.Generic.List<int> myList, int index)
	{
		if (index < 0 || index >= myList.Count)
		{
			Console.WriteLine("Index is out of range");
			return myList;
		}
		var temp = new System.Collections.Generic.List<int>(myList);
		myList.Clear();
		for (int i = 0; i < temp.Count; i++)
			if (i != index)
				myList.Add(temp[i]);
		return myList;
	}
}
