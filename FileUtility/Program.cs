using System;

namespace FileUtility
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			foreach (string arg in args)
			{
				Console.WriteLine(arg);
			}
			Console.ReadLine();
		}
	}
}
