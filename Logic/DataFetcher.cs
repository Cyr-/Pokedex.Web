using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Pokedex.Pokeapi.Common;

namespace Pokedex.Logic.Web
{
    public class DataFetcher
    {
        private const string _uri = "http://pokeapi.co/api/v2/";

        internal static HttpClient client = new HttpClient
        {
            BaseAddress = new Uri(_uri)
        };

        public static async Task<T> GetApiObject<T>(Uri url) where T : ApiObject => JsonConvert.DeserializeObject<T>(await client.GetStringAsync(url.AbsoluteUri));
    }
}