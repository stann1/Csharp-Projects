using System;
using System.Linq;

namespace FreeContentCatalogue
{
    public class Content : IComparable, IContent
    {
        private string url;
        public string Title { get; set; }
        public string Author { get; set; }
        public long Size { get; set; }
        public ContentType Type { get; set; }
        public string TextRepresentation { get; set; }        

        public Content(ContentType contentType, string[] commandParams)
        {
            this.Type = contentType;
            this.Title = commandParams[0];
            this.Author = commandParams[1];
            this.Size = long.Parse(commandParams[2]);
            this.URL = commandParams[3];
        }

        public string URL
        {
            get
            {
                return this.url;
            }
            set
            {
                this.url = value;
                this.TextRepresentation = this.ToString(); // To update the text representation
            }
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            try
            {
                Content otherContent = obj as Content;
                int comparisonResul = this.TextRepresentation.CompareTo(otherContent.TextRepresentation);

                return comparisonResul;
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException("The passed object cannot be parsed to Content item");
            }
            

            
        }

        public override string ToString()
        {
            string output = String.Format("{0}: {1}; {2}; {3}; {4}", this.Type.ToString(), this.Title, this.Author, this.Size, this.URL);

            return output;
        }
    }

}
