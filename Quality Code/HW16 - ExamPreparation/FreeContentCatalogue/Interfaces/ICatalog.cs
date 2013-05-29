using System;
using System.Collections.Generic;
using System.Linq;

namespace FreeContentCatalogue
{
    public interface ICatalog
    {
        void AddContent(IContent content);

        IEnumerable<IContent> GetListContent(string title, int numberOfContentElementsToList);

        int UpdatedContent(string oldUrl, string newUrl);
    }
}
