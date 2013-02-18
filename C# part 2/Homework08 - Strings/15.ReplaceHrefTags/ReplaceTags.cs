using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _15.ReplaceHrefTags
{
    class ReplaceTags
    {
        static void Main(string[] args)
        {
            string text = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. " +
                          "Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

            string pattern = @"<a href=""(.*?)"">(.*?)</a>";
            string replace = @"[URL=""$1""]$2[/URL]";

            string match = Regex.Replace(text, pattern, replace);

            Console.WriteLine(match);
        }
    }
}
