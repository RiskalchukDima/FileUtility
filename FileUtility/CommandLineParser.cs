using System;
using System.IO;

namespace FileUtility
{
	class CommandLineParser
	{
		public void Helper()
		{
			Console.WriteLine($"Hello  {Environment.UserName}!");
			Console.WriteLine($"Is a simple file utility");
			Console.WriteLine($"Usage:");
			Console.WriteLine($"\t{"FileUtility [options] [command]",-70}");
			Console.WriteLine($"Options:");
			Console.WriteLine($"\t{"--help,-h,-?",-20} - {"Show help and usage information",-70}");
			Console.WriteLine($"Commands:");
			Console.WriteLine($"\t{"rename",-20} - {"Rename file",-70}");
			Console.WriteLine($"\t(");
			Console.WriteLine($"\t\tUsage:");
			Console.WriteLine($"\t\t{"FileUtility rename [options]",-70}");
			Console.WriteLine($"\t\tOptions: ");
			Console.WriteLine($"\t\t{"-input (REQUIRED)",-20} - {"The input file name",-70}");
			Console.WriteLine($"\t\t{"-output (REQUIRED)",-20} - {"The output file name",-70}");
			Console.WriteLine($"\t)");

		}

		public void ParseArgs(string[] pters)
		{
			if (pters.Length == 0)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("\nNo options or commands entered\n");
				Console.ResetColor();
				Helper();
			}
			else
			{
				switch (pters[0])
				{
					case "--help":
					case "-h":
					case "-?":
						Helper();
						break;
					case "rename":
						if (pters.Length < 3)
						{
							Console.ForegroundColor = ConsoleColor.Red;
							Console.WriteLine("\nRequired parameters are not filled\n");
							Console.ResetColor();
							Helper();
						}
						else
						{
							RenameMethod(pters[1], pters[2]);
						}
						break;
					default:
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("\nEntered option or command not found\n");
						Console.ResetColor();
						break;
				}
			}
		}

		public void RenameMethod(string input, string output)
		{
			try
			{
				File.Move(input, output);
			}
			catch (Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"\n{ex.Message}\n");
				Console.ResetColor();

			}

		}

	}

}
