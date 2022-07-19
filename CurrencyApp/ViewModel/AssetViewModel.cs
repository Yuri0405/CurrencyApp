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
        public List<Asset>? Assets { get; set; }

        public AssetViewModel()
        {
            _client = new CurrencyAPIClient();
        }
        public async Task GetCurrencies()
        {
            RootObject rootObject = await _client.ProcessCurrency("https://www.cryptingup.com/api/assets?size=10");
            Assets = rootObject.Assets;
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
