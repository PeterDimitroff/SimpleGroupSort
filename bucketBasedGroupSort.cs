using System;
using System.Collections.Generic;

public class Program
{
	public static int[] rockit(int[] arr)
	{
		// sort as 2s before 1s, before 3s
		List<int>[] buckets = new List<int>[3];
		for (int i = 0; i < buckets.Length; i++)
			buckets[i] = new List<int>();
		foreach (int i in arr)
		{
			buckets[i - 1].Add(i);
		}

		buckets[1].AddRange(buckets[0]);
		buckets[1].AddRange(buckets[2]);
		return buckets[1].ToArray();
	}

	public static void Main()
	{
		int[] arr = {1, 2, 1, 1, 3, 3, 2, 3, 1, 2, 2, 3, 3, 2, 1, 2};
		foreach (int i in rockit(arr))
		{
			Console.WriteLine(i);
		}
	}
}