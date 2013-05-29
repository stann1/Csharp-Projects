using System;
using System.Collections.Generic;
using System.Linq;
using Wintellect.PowerCollections;

namespace FreeContentCatalogue
{
    public class Catalog : ICatalog
    {
        private readonly MultiDictionary<string, IContent> urlList;
        private readonly OrderedMultiDictionary<string, IContent> titleList;

        public Catalog()
        {
            bool allowDuplicateValues = true;
            this.titleList = new OrderedMultiDictionary<string, IContent>(allowDuplicateValues);
            this.urlList = new MultiDictionary<string, IContent>(allowDuplicateValues);
        }

        public int Count 
        {
            get
            {
                return this.titleList.KeyValuePairs.Count;
            }
        }

        public void AddContent(IContent content)
        {
            this.titleList.Add(content.Title, content);
            this.urlList.Add(content.URL, content);
        }

        public IEnumerable<IContent> GetListContent(string title, int numberOfContentElementsToList)
        {
            IEnumerable<IContent> contentToList = 
                from content in this.titleList[title] 
                select content;

            return contentToList.Take(numberOfContentElementsToList);
        }

        public int UpdatedContent(string oldUrl, string newUrl)
        {
            int updatedElements = 0;

            List<IContent> contentToList = this.urlList[oldUrl].ToList();

            foreach (Content content in contentToList)
            {
                this.titleList.Remove(content.Title, content);
                updatedElements++; 
            }

            this.urlList.Remove(oldUrl);

            foreach (IContent content in contentToList)
            {
                content.URL = newUrl;
                this.titleList.Add(content.Title, content);
                this.urlList.Add(content.URL, content);
            }           

            return updatedElements;
        }
    }
}
