using System;

namespace FileUtility
{
	static class ConsoleActions
	{

		public static void WriteMessage(string message, ConsoleColor color)
		{
			Console.ForegroundColor = color;
			Console.WriteLine($"\n{message}\n");
			Console.ResetColor();

		}
	}

}
