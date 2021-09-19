using System;
using System.Linq;
using System.Reflection;

namespace FileUtility
{
    using FileUtility.Commands;

	static class CommandLineExecutor
	{
		private const string NoCommandOrOption = "No options or commands entered";
		private const string CommandNotFound = "Command was not found";

		private static ICommand _command;

		public static void Execute(Command commandData)
        {
			if(commandData.Name == string.Empty)
            {
				ConsoleActions.WriteMessage(NoCommandOrOption, ConsoleColor.Red);

				_command = new HelpCommand();
				_command.Execute(commandData);

				return;
            }

			_command = GetCommandByName(commandData.Name);

			if(_command == null)
            {
				ConsoleActions.WriteMessage(CommandNotFound, ConsoleColor.Red);
				return;
            }
			
			_command.Execute(commandData);
        }

		private static ICommand GetCommandByName(string commandName)
        {
			Assembly currentAssembly = Assembly.GetExecutingAssembly();
			Type[] typesFromAssembly = currentAssembly.GetTypes();
			Type[] commands =
				typesFromAssembly
					.Where(type => type.GetCustomAttribute(typeof(CommandNameAttribute)) != null)
					.ToArray();

			Type command =
				commands
					.Where(type => type.GetCustomAttribute<CommandNameAttribute>().Name.Equals(commandName, StringComparison.OrdinalIgnoreCase))
					.FirstOrDefault();

			if(command != null)
            {
				return Activator.CreateInstance(command) as ICommand;
            }
            else
            {
				return null;
            }
 		}
	}
}
