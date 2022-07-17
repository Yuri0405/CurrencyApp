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
        public async Task<List<Asset>> ProcessCurrency()
        {
            ///*
            var streamTask = client.GetStreamAsync("https://www.cryptingup.com/api/assets?size=10");
            var rootObject = await JsonSerializer.DeserializeAsync<RootObject>(await streamTask);
            var assets = rootObject.Assets;//*/

            return assets;
        }
    }
}
