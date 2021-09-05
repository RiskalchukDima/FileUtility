using System;
using System.IO;

namespace FileUtility
{
	static class CommandLineExecutor
	{
		private const string SucessfullyRename = "File renamed sucessfully";
		public static void Rename(string [] parameters)
		{
			try
			{
				File.Move(parameters[1], parameters[2]);
				ConsoleActions.WriteMessage(SucessfullyRename, ConsoleColor.Green);
			}
			catch (Exception ex)
			{
				ConsoleActions.WriteMessage(ex.Message, ConsoleColor.Red);
			}
		}
	}
}
