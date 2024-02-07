using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
	internal class Program
	{
		static void Main(string[] args)
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
