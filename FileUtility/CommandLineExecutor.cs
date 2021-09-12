using System;

namespace FileUtility
{
	using FileUtility.Commands;

	static class CommandLineExecutor
	{
		private const string NoCommandOrOption = "No options or commands entered";

		private static ICommand _command;

		public static void Execute(Command commandData)
        {
			if(commandData.Name == string.Empty)
            {
				ConsoleActions.WriteMessage(NoCommandOrOption, ConsoleColor.Red);

				_command = new HelpCommand();
				_command.Execute(commandData);
            }

			// TODO: reflection logic
        }
	}
}
