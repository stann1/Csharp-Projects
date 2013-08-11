using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace _01.MongoDictionary
{
    public class Word : IWord
    {
        public Word(string word, string definition)
        {
            this.GetWord = word;
            this.GetDefinition = definition;
        }

        public ObjectId Id { get; set; }

        public string GetWord { get; set; }

        public string GetDefinition { get; set; }

    }

    public interface IWord
    {
        string GetWord { get; set; }
        string GetDefinition { get; set; }
    }
}
