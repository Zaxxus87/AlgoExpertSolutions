using System;
using System.Collections.Generic;

class Program
{
   static void Main(string[] args)
   {
		string output = "[";
		var ray = InsertionSort(new int[] { 3,1,7,2,9,5,6,8,4 });
		foreach(int num in ray)
        {
			output += $"{num}, ";
        }
        output = output.TrimEnd(' ');
		output = output.TrimEnd(',') + "]";
        Console.WriteLine(output);

	}

	public static int[] InsertionSort(int[] array)
	{
		for (int i = 0; i < array.Length - 1; i++)
		{
			int j = i + 1;
			int temp = array[j];
			while (j > 0 && temp < array[j - 1])
			{
				array[j] = array[j - 1];
				j--;
			}
			array[j] = temp;
		}
		return array;
	}
}
