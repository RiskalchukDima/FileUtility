namespace FileUtility
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] parameters = args;
			CommandLineParser clp = new CommandLineParser();
			clp.ParseArgs(parameters);

		}
	}

}
