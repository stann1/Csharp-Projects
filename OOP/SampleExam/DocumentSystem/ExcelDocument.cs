using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem_1
{
    public class ExcelDocument : OfficeDocument
    {
        public int? NumberOfRows { get; private set; }
        public int? NumberOfCols { get; private set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "rows")
            {
                this.NumberOfRows = int.Parse(value);
            }
            else if (key == "cols")
            {
                this.NumberOfCols = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
           
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("rows", this.NumberOfRows));
            output.Add(new KeyValuePair<string, object>("cols", this.NumberOfCols));
        }
    }
}
