using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4__DoublyLinkedLists
{
	class Program
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
		private static bool isRunning;

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
		}

		/* RUN METHOD */
		private static void Run()
		{
			// Main loop.
			while (isRunning)
			{
				// TODO run program here.
			}
		}

		/* SERVICE METHODS */

		//// USER INPUT
		private string GetUserInput(string prompt)
		{
			// Write prompt.
			Console.Write(prompt);

			// Ask for user input.
			return Console.ReadLine();
		}

		private void TakeUserInput(string input)
		{
			// Check to see if it is a special command.
			// If it is not a special command, add it to the list.
			if (!IsSpecial(input))
			{
				// TODO add to list here.
			}
		}

		// This returns a false if it is not a special command.
		// If it IS a special command, it also RUNS the command.
		private bool IsSpecial(string cmd)
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
		private void Quit()
		{
			// The program is no longer running.
			isRunning = false;
		}

		private void Print() { }

		private void Count() { }

		private void Clear() { }

		private void Remove() { }

		private void Scramble() { }

	}
}
