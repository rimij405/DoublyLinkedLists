using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4__DoublyLinkedLists
{
	public class LinkedList : IList
	{
		// Instance variables.
		private Node head;
		private Node tail;
		private int count;

		// Default constructor.
		public LinkedList()
		{
			count = 0;
		}
		
		// Return the count.
		public int Count
		{
			get { return this.count; }
		}

		public void Add(string data)
		{
			// Add a new Node object.
			Node insert = new Node(data);

			// Increment the count.
			count++;

			// Update references.
			if (head == null)
			{
				// If head is null, tail is also null.
				head = insert; // First element is now, thusly, insert.
				tail = null;

				// The nodes' references should be null.
				head.Next = null; // insert.Next = tail;
				head.Previous = null; // insert.Previous = tail;
			}
			else
			{
				if (tail == null)
				{
					// If head is not null, but tail is null.
					// head = head; // Reference does not change.
					tail = insert;

					// The nodes' references should change.
					head.Previous = tail;
					tail.Next = head; // insert.Next = head;
				}
				else
				{
					// If neither head, nor tail, is null.
					// head = head; // Reference does not change.
					Node tempTail = tail; // Store current tail.
					tail = insert; // Replace tail as insert.

					// Reassing all node references.
					head.Previous = tail; // The head's previous is the new tail.
					tail.Previous = tempTail; // The new tail's previous is the old tail.
					tail.Next = head; // The new tail's next is the head.
				}
			}
		}

		public void Clear()
		{
			// Clear the list and its attributes.
			head = null;
			tail = null;
			count = 0;
		}

		public string GetElement(int index)
		{
			// Is index value invalid?
			if (index < 0 || index >= count) { return null; }

			if (index == 0) { return head.Data; } // FIRST
			if (index == (count - 1)) { return tail.Data; } // LAST

			// If neither head, nor tail, we need to search for it:
			// Create node reference.
			Node temp = new Node(null); // Fill it with a null reference.
			
			// Is the index greater than half the count?
			bool startFromEnd = ((index + 1) >= (int)(count / 2));
			
			if (startFromEnd)
			{
				// If start from end?
				// Get tail.
				temp = tail;

				// Loop, backwards until you reach the value (count - 1) - ((count - 1) - (index));
				int start = (count - 1);
				// int loopCondition = (start - (start - index));
				// for (int i = start; i >= loopCondition; i--)
				for (int i = start; i > index; i--)
				{
					temp = temp.Previous;
				}
			}
			else
			{
				// If not start from end?
				// Get head.
				temp = head;

				// Loop, forwards until you reach the value (0 + index).
				for (int j = 0; j < index; j++)
				{
					temp = temp.Next;
				}
			}

			// If the data itself is now null, return null.
			if (temp.Data == null) { return null; }

			// Return the data at that node.
			return temp.Data;
		}

		public void Insert(string data, int index)
		{
			// If index is less than zero or equal to zero.
			if (index <= 0)
			{
				// Create the node object.
				Node insert = new Node(data);

				// Insert node at position 0.
				Node tempHead = head;
				head = insert;

				// Assign new references.
				head.Next = tempHead;
				head.Previous = tail;
				tail.Previous = head;

				// Increment the count.
				count++;
			}
			// If the index is greater or equal to the count.
			else if (index >= count)
			{
				// Simply append the data to a new node at the end of the LinkedList.
				Add(data);

				// Counting is handled from within the Add() method.
				// count++;
			}
			// If the index is the one next to the head reference.
			else if (index == 1)
			{
				// Create the node object.
				Node insert = new Node(data);

				// Get the temp references.
				Node right = head.Next;

				// Reassign other references.
				head.Next = insert;
				right.Previous = insert;

				// Assign insert node references.
				insert.Next = right;
				insert.Previous = head;

				// Increment.
				count++;
			}
			// If the index is the one previous to the tail reference.
			else if (index == (count - 2))
			{
				// Create the node object.
				Node insert = new Node(data);

				// Get the temp references.
				Node left = tail.Previous;

				// Reassign other references.
				tail.Previous = insert;
				left.Next = insert;

				// Assign insert node references.
				insert.Previous = left;
				insert.Next = tail;

				// Increment.
				count++;
			}
			// If the index is safely between 1 and (count - 1), exclusive.
			else
			{
				// Create the node object.
				Node insert = new Node(data);

				// Loop through the area. (Index already confirmed to be valid at this point.)
				Node temp = head;
				for (int i = 0; i < index; i++)
				{
					temp = temp.Next;
				}

				// Get the nodes left and right of insert.
				Node left = temp.Previous;
				// Node right = temp; // To save memory, we do not need to create a new node object.

				// Reassign other references.
				left.Next = insert;
				temp.Previous = insert; // right.Previous = insert;

				// Assign insert node references.
				insert.Previous = left;
				insert.Next = temp; // insert.Next = right;

				// Increment.
				count++;
			}
		}

		public string Remove(int index)
		{
			// REMOVE A NODE FROM THE LIST.
			return null;
		}
	}
}
