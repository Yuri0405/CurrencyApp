using CurrencyApp.Model;
using CurrencyApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyApp.ViewModel
{
    internal class CurrencyDetailViewModel
    {
        private readonly CurrencyAPIClient _client;

        public Asset? Asset { get; set; }

        public CurrencyDetailViewModel()
        {
            _client = new CurrencyAPIClient();
        }

        public async Task GetCurrency(string currencyId)
        {
            RootObject rootObject = await _client.ProcessCurrency("https://www.cryptingup.com/api/assets/" + currencyId);
            Asset = rootObject.Asset;
        }
    }
}
