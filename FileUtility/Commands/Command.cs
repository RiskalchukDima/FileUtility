namespace FileUtility.Commands
{
    class Command
    {
        public string Name { get; set; }

        public string[] Arguments { get; set; }

        public string[] Options { get; set; }

        public Command()
        {
            Name = string.Empty;
            Arguments = new string[0];
            Options = new string[0];
        }
    }
}
