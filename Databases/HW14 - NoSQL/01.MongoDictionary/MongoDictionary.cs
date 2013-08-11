using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace _01.MongoDictionary
{
    public class MongoDictionary<T> where T : IWord
    {
        private MongoClient client;
        private MongoServer server;
        private MongoDatabase dictionaryDB;
        private MongoCollection<Word> collection;
        private IQueryable<T> queryableCollection;

        public MongoDictionary(string database, string collection)
        {
            this.client = new MongoClient("mongodb://localhost");
            this.server = client.GetServer();
            this.dictionaryDB = server.GetDatabase(database);

            this.collection = dictionaryDB.GetCollection<Word>(collection);
            queryableCollection = this.collection.AsQueryable<T>();
        }

        public void StoreInHash(T obj)
        {
            collection.Insert(obj);
        }

        public T GetFromHash(string key)
        {
            var obj = queryableCollection.Where(x => x.GetWord == key).First();

            return obj;
        }

        public IEnumerable<T> GetHashObjects()
        {
            return queryableCollection.AsEnumerable();
        }
    }
}
