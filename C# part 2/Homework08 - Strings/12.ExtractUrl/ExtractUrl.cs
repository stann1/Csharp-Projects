using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12.ExtractUrl
{
    class ExtractUrl
    {
        static void Main(string[] args)
        {
            string url = "http://www.devbg.org/forum/index.php";

            int indexProt = url.IndexOf(':');
            string protocol = url.Substring(0, indexProt);

            int indexServ = url.IndexOf('/', indexProt + 3);
            string server = url.Substring(indexProt + 3, indexServ - indexProt - 3);
            
            string resource = url.Substring(indexServ);

            Console.WriteLine("[protocol] = \"{0}\"", protocol);
            Console.WriteLine("[server] = \"{0}\"", server);
            Console.WriteLine("[resource] = \"{0}\"", resource);
        }
    }
}
