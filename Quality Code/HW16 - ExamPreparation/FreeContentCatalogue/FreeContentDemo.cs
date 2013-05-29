using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FreeContentCatalogue
{
    public class FreeContentDemo
    {
        public static void Main()
        {
            StringBuilder output = new StringBuilder();
            Catalog catalog = new Catalog();
            ICommandExecutor commandExecutor = new CommandExecutor();
            List<ICommand> commandList = GetParsedCommands();

            foreach (ICommand command in commandList)
            {
                commandExecutor.ExecuteCommand(catalog, command, output); 
            }
                       
            Console.Write(output); 
        }

        private static List<ICommand> GetParsedCommands()
        {
            List<ICommand> commandList = new List<ICommand>();
            bool endCommandPassed = false;

            do
            {
                string input = Console.ReadLine();
                endCommandPassed = (input.Trim() == "End");
                if (!endCommandPassed)
                {
                    commandList.Add(new Command(input));
                }
            }
            while (!endCommandPassed);

            return commandList;
        }
    }
}