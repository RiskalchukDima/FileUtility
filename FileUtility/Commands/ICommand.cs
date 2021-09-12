namespace FileUtility.Commands
{
    interface ICommand
    {
        void Execute(Command commandData);
    }
}
