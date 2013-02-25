using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.VersionAttribute
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Enum
        | AttributeTargets.Interface | AttributeTargets.Method)]
    public class VersionAttribute : System.Attribute
    {
        private string version;

        //Properties
        public string Version
        {
            get { return this.version; }
        }

        //Constructor
        public VersionAttribute(string version)
        {
            this.version = version;
        }
    }

}
