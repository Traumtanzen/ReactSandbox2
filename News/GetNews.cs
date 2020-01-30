using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ReactSandbox2.News
{
    public class GetNews
    {
        private static async Task<string> GetJson()
        {
            var client = new HttpClient();
            var result = await client.GetAsync("https://newsapi.org/v2/top-headlines?country=us&apiKey=7b14f60aa1334a61912771ea556ae7e4");
            return await result.Content.ReadAsStringAsync();
        }


    }
}
