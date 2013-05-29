using System;
using System.Linq;
using System.Text;

namespace FreeContentCatalogue
{
    public class Command : ICommand
    {
        private readonly char[] paramsSeparators = { ';' };
        private readonly char commandEnd = ':';
        private int commandNameEndIndex;

        public CommandType Type { get; set; }
        public string OriginalForm { get; set; }
        public string Name { get; set; }
        public string[] Parameters { get; set; }       

        public Command(string input)
        {
            this.OriginalForm = input.Trim();
            this.Parse();
        }

        private void Parse()
        {
            this.commandNameEndIndex = this.GetCommandNameEndIndex();
            this.Name = this.ParseCommandName();
            this.Parameters = this.ParseCommandParameters();
            this.TrimParams();
            this.Type = this.ParseCommandType(this.Name);
        }

        public CommandType ParseCommandType(string commandName)
        {
            CommandType type;

            if (commandName.Contains(':') || commandName.Contains(';'))
            {
                throw new FormatException("The command name cannot contain special symbols \";\" or \":\"");
            }

            switch (commandName.Trim())
            {
                case "Add book":
                        type = CommandType.AddBook;
                    break;
                case "Add movie":
                        type = CommandType.AddMovie;
                    break;
                case "Add song":
                        type = CommandType.AddSong;
                    break;
                case "Add application":
                        type = CommandType.AddApplication;
                    break;
                case "Update":
                        type = CommandType.Update;
                    break;
                case "Find":
                        type = CommandType.Find;
                    break;
                default:
                    throw new ArgumentException("The command is invalid", commandName);
            }

            return type;
        }

        public string ParseCommandName()
        {
            string name = this.OriginalForm.Substring(0, this.commandNameEndIndex);
            return name;
        }

        public string[] ParseCommandParameters()
        {
            int paramStartIndex = this.commandNameEndIndex + 2;
            int paramsLength = this.OriginalForm.Length - paramStartIndex;
            string paramsOriginalForm = this.OriginalForm.Substring(paramStartIndex, paramsLength);
            string[] parameters = paramsOriginalForm.Split(paramsSeparators, StringSplitOptions.RemoveEmptyEntries);

            return parameters;
        }

        public int GetCommandNameEndIndex()
        {
            int endIndex = this.OriginalForm.IndexOf(commandEnd);

            return endIndex;
        }

        private void TrimParams()
        {
            for (int i = 0; ; i++)
            {
                if (!(i < this.Parameters.Length))
                {
                    break;
                }
                this.Parameters[i] = this.Parameters[i].Trim();
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Name);
            sb.Append(" ");            

            foreach (string param in this.Parameters)
            {
                sb.Append(param);
                sb.Append(" ");
            }
            return sb.ToString().Trim();
        }
    }
}
