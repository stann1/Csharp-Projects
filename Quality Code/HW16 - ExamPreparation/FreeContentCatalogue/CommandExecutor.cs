using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FreeContentCatalogue
{
    public class CommandExecutor : ICommandExecutor
    {
        public void ExecuteCommand(ICatalog catalog, ICommand command, StringBuilder output)
        {
            switch (command.Type)
            {
                case CommandType.AddBook:
                    {
                        catalog.AddContent(new Content(ContentType.Book, command.Parameters));
                        output.AppendLine("Book added");
                    }
                    break;
                case CommandType.AddMovie:
                    {
                        catalog.AddContent(new Content(ContentType.Movie, command.Parameters));
                        output.AppendLine("Movie added");
                    }
                    break;
                case CommandType.AddSong:
                    {
                        catalog.AddContent(new Content(ContentType.Song, command.Parameters));
                        output.AppendLine("Song added");
                    }
                    break;
                case CommandType.AddApplication:
                    {
                        catalog.AddContent(new Content(ContentType.Application, command.Parameters));
                        output.AppendLine("Application added");
                    }
                    break;
                case CommandType.Update:
                    {
                        if (command.Parameters.Length != 2)
                        {
                            throw new ArgumentOutOfRangeException("The number of paramaters must be exactly two");                           
                        }
                        int updateContentCount = catalog.UpdatedContent(command.Parameters[0], command.Parameters[1]);
                        output.AppendLine(String.Format("{0} items updated", updateContentCount));                     
                    }
                    break;
                case CommandType.Find:
                    {
                        FindContent(command, catalog, output);
                    }
                    break;
                default:
                    {
                        throw new InvalidCastException("Unknown command!");
                    }
            }
        }
  
        private void FindContent(ICommand command, ICatalog catalog, StringBuilder output)
        {
            if (command.Parameters.Length != 2)
            {
                throw new ArgumentOutOfRangeException("The number of paramaters must be exactly two");    
            }

            int numberOfElementsToList = int.Parse(command.Parameters[1]);
            IEnumerable<IContent> foundContent = catalog.GetListContent(command.Parameters[0], numberOfElementsToList);

            if (foundContent.Count() == 0)
            {
                output.AppendLine("No items found");
            }
            else
            {
                foreach (IContent content in foundContent)
                {
                    output.AppendLine(content.TextRepresentation);
                }
            }
        }
    }
}
