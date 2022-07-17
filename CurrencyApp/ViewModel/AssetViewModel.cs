using CurrencyApp.Model;
using CurrencyApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace CurrencyApp.ViewModel
{
    internal class AssetViewModel:INotifyPropertyChanged
    {
        private readonly CurrencyAPIClient _client;
        //public ObservableCollection<Asset> Assets { get; set; }
        public List<Asset>? Assets { get; set; }

        public AssetViewModel()
        {
            _client = new CurrencyAPIClient();
            /*Assets = new ObservableCollection<Asset> {
                new Asset{Asset_id = "USDT", Name = "Tether", Price = 0.9998M},
                new Asset{Asset_id = "BTC", Name = "Bitcoin", Price = 21291.16M},
                new Asset{Asset_id = "ETH", Name = "Ethereum", Price = 1342.41499M}
            };*/
        }
        public async Task GetCurrencies()
        {
            Assets = await _client.ProcessCurrency();
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
