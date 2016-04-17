using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4__DoublyLinkedLists
{
	public class Program
	{
		/* SPECIAL COMMANDS */
		private const string Q = "q";
		private const string QUIT = "quit";
		private const string PRINT = "print";
		private const string COUNT = "count";
		private const string CLEAR = "clear";
		private const string REMOVE = "remove";
		private const string SCRAMBLE = "scramble";

		/* VARIABLES */
		public static Random random;
		private static bool isRunning;
		private static LinkedList linkedList;

		/* MAIN METHOD OF THE TEST CLASS */
		public static void Main(string[] args)
		{
			Initialize();
			Run();
		}

		/* INITIALIZE METHOD */
		private static void Initialize()
		{
			// Set any variables here.
			isRunning = true;

			// Set any objects here.
			linkedList = new LinkedList();
			random = new Random();
		}

		/* RUN METHOD */
		private static void Run()
		{
			// Main loop.
			while (isRunning)
			{
				// Get and process input.
				TakeUserInput(GetUserInput("Type something: "));
				Console.WriteLine("< Press enter to continue. >");
				Console.ReadLine();
				
				Console.WriteLine("-----");
			}

			Console.WriteLine("Thank you! The program will now end!");
			Console.ReadLine();
		}

		/* SERVICE METHODS */

		//// USER INPUT
		private static string GetUserInput(string prompt)
		{
			// Write prompt.
			Console.Write(prompt);

			// Ask for user input.
			return Console.ReadLine();
		}

		private static void TakeUserInput(string input)
		{
			// Check to see if it is a special command.
			// If it is not a special command, add it to the list.
			if (!IsSpecial(input))
			{
				// Add the input as a string into LinkedList.
				linkedList.Add(input);

				Console.WriteLine("Appended \"" + input + "\" to the end of the LinkedList.");
			}
		}

		// This returns a false if it is not a special command.
		// If it IS a special command, it also RUNS the command.
		private static bool IsSpecial(string cmd)
		{
			// Set string to lowercase.
			string str = cmd.ToLower();

			// Quit
			if (str == Q || str == QUIT)
			{
				Quit();
				return true;
			}

			// Print
			if (str == PRINT)
			{
				Print();
				return true;
			}

			// Count
			if (str == COUNT)
			{
				Count();
				return true;
			}

			// Clear
			if (str == CLEAR)
			{
				Clear();
				return true;
			}

			// Remove
			if (str == REMOVE)
			{
				Remove();
				return true;
			}

			// Scramble
			if (str == SCRAMBLE)
			{
				Scramble();
				return true;
			}

			// Default
			return false;
		}


		/* COMMAND METHODS */
		private static void Quit()
		{
			Console.WriteLine("QUIT(): { end program; }");

			// The program is no longer running.
			isRunning = false;
		}

		private static void Print()
		{
			Console.WriteLine("PRINT(): {\n");
			
			// Print everything in the list.
			for (int index = 0; index < linkedList.Count; index++)
			{
				Console.WriteLine("\t\"" + linkedList.GetElement(index) + "\"");
			}
			
			Console.WriteLine("\n}");
		}

		private static void Count()
		{
			Console.WriteLine("COUNT(): {\n");
			Console.WriteLine("\tThere are " + linkedList.Count + " elements in the LinkedList.");
			Console.WriteLine("\n}");
		}

		private static void Clear()
		{
			Console.WriteLine("Clear(): { clear list; }");
			linkedList.Clear();
		}

		private static void Remove()
		{
			Console.WriteLine("REMOVE(): {\n // REMOVES ONE ELEMENT AT RANDOM\n");

			int index = random.Next(0, (linkedList.Count - 1));
			Console.WriteLine("\tRemoving element from index: " + index);
			Console.WriteLine("\tElement removed: \"" + linkedList.Remove(index) + "\"");

			Console.WriteLine("\n}");
		}

		private static void Scramble()
		{
			Console.WriteLine("SCRAMBLE(): {\n");

			// Get random values for the scramble:
			int itemsToScramble = random.Next(0, (linkedList.Count - 1));

			for (int i = 0; i < itemsToScramble; i++)
			{
				int index = random.Next(0, (linkedList.Count - 1)); // Grab the item.
				string temp = linkedList.Remove(index);

				Console.WriteLine("\tRemoving element from index: " + index);
				Console.WriteLine("\tElement removed: \"" + temp + "\"");

				int insert = random.Next(0, (linkedList.Count - 1));
				linkedList.Insert(temp, insert);

				Console.WriteLine("\tInserting element at index: " + insert);
				Console.WriteLine("\tElement inserted: \"" + linkedList.GetElement(insert) + "\"");
			}

			Console.WriteLine("\n}");
		}

	}
}
