using System;

namespace ConsoleUI
{
	internal class Program
	{
		private static void Main()
		{
			Console.Write("What is your first name: ");
			string firstname = Console.ReadLine();

			if ( firstname.ToLower() == "tim" )
			{
				Console.WriteLine("Hello Professor!");
			}
			else
			{
				Console.WriteLine("Hello Student!");
			}

			_ = Console.ReadLine();
		}
	}
}
