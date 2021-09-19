using System;

namespace FileUtility.Commands
{
	[CommandName(Name = "help")]
	class HelpCommand : ICommand
    {
        public void Execute(Command commandData)
        {
			Console.WriteLine($"Hello  {Environment.UserName}!");
			Console.WriteLine($"Is a simple file utility");
			Console.WriteLine($"Usage:");
			Console.WriteLine($"\t{"FileUtility [command] [options] [arguments]",-70}");
			Console.WriteLine($"Options:");
			Console.WriteLine($"\t{"--help,-h,-?",-20} - {"Show help and usage information",-70}");
			Console.WriteLine($"Commands:");
			Console.WriteLine($"\t{"rename",-20} - {"Rename file",-70}");
			Console.WriteLine($"\t(");
			Console.WriteLine($"\t\tUsage:");
			Console.WriteLine($"\t\t{"FileUtility rename [arguments]",-70}");
			Console.WriteLine($"\t\tArguments: ");
			Console.WriteLine($"\t\t{"-input (REQUIRED)",-20} - {"The input file name",-70}");
			Console.WriteLine($"\t\t{"-output (REQUIRED)",-20} - {"The output file name",-70}");
			Console.WriteLine($"\t)");
		}
    }
}
