using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MusicStore.Data;

// Before running anything - right click solution --> "Manage Nuget Packages for this solution" --> "Restore"

namespace MusicStore.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:58118/")
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            GetAllAlbums(client);
            //AddSongToDB(client);
        }
  
        private static void AddSongToDB(HttpClient client)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }
  
        private static void GetAllAlbums(HttpClient client)
        {
            HttpResponseMessage response = client.GetAsync("api/album").Result;

            if (response.IsSuccessStatusCode)
            {
                var albums = response.Content.ReadAsAsync<IEnumerable<Album>>().Result;
                foreach (var a in albums)
                {
                    Console.WriteLine("{0,4} {1,-20} {2}",
                        a.AlbumId, a.Title, a.Songs.Count);
                }
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
        }
    }
}
