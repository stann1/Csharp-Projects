using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem_1
{
    public abstract class Document : IDocument
    {
        public string Name { get;  protected set; }
        public string Content { get; protected set; }

        public virtual void LoadProperty(string key, string value)
        {
            if (key == "name")
            {
                this.Name = value;
            }
            else if (key == "content") 
            {
                this.Content = value;
            }            
        }

        public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("name", this.Name));
            output.Add(new KeyValuePair<string, object>("content", this.Content));
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            List<KeyValuePair<string, object>> properties = new List<KeyValuePair<string, object>>();
            
            this.SaveAllProperties(properties);
            
            //Sorting with LINQ alphabetically
            var sortedProperties =
                from prop in properties
                orderby prop.Key
                select prop;

            sb.Append(this.GetType().Name);

            if (this is IEncryptable && ((IEncryptable)this).IsEncrypted == true)
            {
                sb.Append("[encrypted]");
            }
            else
	        {
                sb.Append("[");
                
                foreach (var prop in sortedProperties)
                {
                    if (prop.Value != null)
                    {
                        sb.Append(prop.Key);
                        sb.Append("=");
                        sb.Append(prop.Value);
                        sb.Append(";");
                    }
                }
                sb.Length--;
                sb.Append("]");
	        }

            return sb.ToString();
        }
    }
}
