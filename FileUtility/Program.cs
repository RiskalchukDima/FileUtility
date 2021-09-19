namespace FileUtility
{
	using FileUtility.Commands;

	class Program
	{
		static void Main(string[] args)
		{
			Command cliCommand = CommandLineParser.ParseArgs(args);
			CommandLineExecutor.Execute(cliCommand);
		}
	}
}
