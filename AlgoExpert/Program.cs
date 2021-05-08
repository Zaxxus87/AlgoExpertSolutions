using System;
using System.Collections.Generic;


class Program
{
   static void Main(string[] args)
    {
		var test = new LLClass(1);
		test.Add(1);
		test.Add(1);
		test.Add(3);
		test.Add(4);
		test.Add(4);
		test.Add(4);
		test.Add(5);
		test.Add(6);
		test.Add(6);
        Console.WriteLine(test.PrintList());
        Console.WriteLine(RemoveDuplicatesFromLinkedList(test).PrintList());
	}

	public static LLClass RemoveDuplicatesFromLinkedList(LLClass linkedList)
    {
		LLClass temp = linkedList;
        //Console.WriteLine(temp.PrintList());
		while (temp.Next != null)
        {
			while (temp.Next != null && temp.Value == temp.Next.Value)
			{
				if (temp.Next.Next != null)
					temp.Next = temp.Next.Next;
				else
					temp.Next = null;
			}
			if (temp.Next != null)
				temp = temp.Next;
		}
		return linkedList;
	}
}
