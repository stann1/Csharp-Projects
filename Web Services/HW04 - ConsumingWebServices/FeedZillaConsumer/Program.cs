using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FeedZillaConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://api.feedzilla.com/");

            string query = "Hollywood";
            int? numberOfResults = null;

            PrintQueryResults(client, query, numberOfResults);
            System.Threading.Thread.Sleep(3000);
        }
  
        private static async void PrintQueryResults(HttpClient client, string query, int? numberOfResults = null)
        {
            string searchString = "";
            if (numberOfResults != null && numberOfResults > 0)
            {
                searchString = string.Format("v1/articles/search.json?q={0}&count={1}", query, numberOfResults);
            }
            else
            {
                searchString = string.Format("v1/articles/search.json?q={0}", query);
            }

            var response = await client.GetAsync(searchString);
            string result = response.Content.ReadAsStringAsync().Result;
            var articles = JsonConvert.DeserializeObject<ArticleCollection>(result);

            Console.WriteLine(articles);
        }
    }
}
