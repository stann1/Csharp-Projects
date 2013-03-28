﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem_1
{
    public class PDFDocument : EncryptableDocument
    {
        public int? NumberOfPages { get; private set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "pages")
            {
                this.NumberOfPages = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
            
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("pages", this.NumberOfPages));
        }
    }
}
