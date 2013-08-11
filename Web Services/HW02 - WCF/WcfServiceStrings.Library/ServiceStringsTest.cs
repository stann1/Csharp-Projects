using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;

namespace WcfServiceStrings.Library
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ServiceStringsTest : IServiceStringsTest
    {
        public int FindStringRepetitionInTargetString(string toCheck, string targetString)
        {
            var matches = Regex.Matches(targetString.ToLower(), toCheck);
            return matches.Count;
        }
        
    }
}
