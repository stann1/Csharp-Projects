﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem_1
{
    public abstract class BinaryDocument : Document
    {
        public int? SizeInBytes { get; private set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "size")
            {
                this.SizeInBytes = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("size", this.SizeInBytes));
        }

    }
}