using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedZillaConsumer
{
    public class ArticleCollection
    {
        public IEnumerable<Article> Articles { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (this.Articles != null)
            {                
                foreach (var article in this.Articles)
                {
                    sb.AppendLine(string.Format("Title: {0}, url: {1}", article.Title, article.Url));
                }
            }
            return sb.ToString();
        }
    }
  
    
}
