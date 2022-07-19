using CurrencyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CurrencyApp.Services
{
    internal class CurrencyAPIClient
    {
        private static readonly HttpClient client = new HttpClient();
        public async Task<RootObject> ProcessCurrency(string url)
        {
            var streamTask = client.GetStreamAsync(url);
            var rootObject = await JsonSerializer.DeserializeAsync<RootObject>(await streamTask);

            return rootObject;
        }
    }
}
