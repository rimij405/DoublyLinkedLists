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
	/// Represents one node in a Linked List
	/// </summary>
	public class Node
	{
		// Attributes
		private string data;    // The data in this node
		private Node next;  // The next node in the list
		private Node previous;  // The previous node in the list

		/// <summary>
		/// Gets and sets the data of this node
		/// </summary>
		public string Data
		{
			get { return data; }
			set { data = value; }
		}

		/// <summary>
		/// Gets and sets the next node
		/// </summary>
		public Node Next
		{
			get { return next; }
			set { next = value; }
		}

		/// <summary>
		/// Gets and sets the previous node
		/// </summary>
		public Node Previous
		{
			get { return previous; }
			set { previous = value; }
		}

		/// <summary>
		/// Creates a new Node with data
		/// </summary>
		/// <param name="data">The data to hold in this node</param>
		public Node(string data)
		{
			this.data = data;
			this.next = null;
			this.previous = null;
		}

	}
}
