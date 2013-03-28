using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem_1
{
    public class WordDocument : OfficeDocument, IEditable
    {
        public int? NumberOfCharacters { get; private set; }

        public void ChangeContent(string newContent)
        {
            this.Content = newContent;
        }

        public override void LoadProperty(string key, string value)
        {
            if (key == "chars")
            {
                this.NumberOfCharacters = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
            
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("chars", this.NumberOfCharacters));
        }
    }
}
