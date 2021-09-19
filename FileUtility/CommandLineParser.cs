using System.Collections.Generic;
using System.Linq;

namespace FileUtility
{
    using FileUtility.Commands;

    static class CommandLineParser
    {
        public static Command ParseArgs(string[] parameters)
        {
            if (parameters == null || parameters.Length == 0)
            {
                return new Command();
            }

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
