using System;
using System.IO;

namespace FileUtility.Commands
{
    [CommandName(Name = "rename")]
    class RenameCommand : ICommand
    {
        private const string SucessfullyRename = "File renamed sucessfully";

        public void Execute(Command commandData)
        {
            try
            {
                File.Move(commandData.Arguments[0], commandData.Arguments[1]);
                ConsoleActions.WriteMessage(SucessfullyRename, ConsoleColor.Green);
            }
            catch (Exception ex)
            {
                ConsoleActions.WriteMessage(ex.Message, ConsoleColor.Red);
            }
        }
    }
}
