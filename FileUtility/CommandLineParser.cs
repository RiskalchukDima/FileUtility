using System.Collections.Generic;
using System.Linq;

namespace FileUtility
{
    static class CommandLineParser
    {
        private const string NoCommandOrOption = "No options or commands entered";
        private const string InvalidCommandOrOption = "Entered option or command not found";

        public static Command ParseArgs(string[] parameters)
        {
            if (parameters == null || parameters.Length == 0)
            {
                // To check
                return new Command();
            }

            //switch (parameters[0])
            //{
            //	case "--help":
            //	case "-h":
            //	case "-?":
            //		Helper();
            //		break;
            //	case "rename":
            //		CommandLineExecutor.Rename(parameters);
            //		break;
            //	default:
            //		ConsoleActions.WriteMessage(InvalidCommandOrOption, ConsoleColor.Red);
            //		break;
            //}

            string commandName = parameters[0];
            string[] commandArguments = ParseArguments(parameters.Skip(1).ToArray());
            string[] commandOptions = ParseOptions(parameters.Skip(1).ToArray());

            return new Command
            {
                Name = commandName,
                Arguments = commandArguments,
                Options = commandOptions
            };
        }

        // To check
        private static string[] ParseArguments(string [] parameters)
        {
            List<string> arguments = new List<string>();

            foreach (var item in parameters)
            {
                if(item[0] != '-')
                {
                    arguments.Add(item);
                }
            }

            return arguments.ToArray();
        }

        private static string[] ParseOptions(string[] parameters)
        {
            List<string> options = new List<string>();

            foreach (var item in parameters)
            {
                if (item[0] == '-')
                {
                    options.Add(item);
                }
            }

            return options.ToArray();
        }
    }
}
