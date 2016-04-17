using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4__DoublyLinkedLists
{

	// < THIS CLASS WAS PROVIDED AS-IS BY THE PROFESSOR
	// AS PART OF THE ASSIGNMENT. >

	/// <summary>
	/// The interface for a simple Linked List
	/// </summary>
	public interface IList
	{
		// Add a new element to the end of the list.
		void Add(string data);

		// Inserts a new element at a specified location in the list.
		void Insert(string data, int index);

		// Remove an element from a specified location in 
		// the list and return the data
		string Remove(int index);

		// Return the element at this index in the list.
		string GetElement(int index);

		// Clears the list
		void Clear();

		// The current number of items in this list.
		int Count { get; }

	}
}
