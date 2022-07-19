using CurrencyApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CurrencyApp.View
{
    /// <summary>
    /// Interaction logic for CurrencyDetail.xaml
    /// </summary>
    public partial class CurrencyDetail : Page
    {
        private readonly CurrencyDetailViewModel _currencyDetailViewModel;
        public CurrencyDetail()
        {
            InitializeComponent();
            _currencyDetailViewModel = new CurrencyDetailViewModel();
        }

        private async void buttonGetCurrency(object sender, RoutedEventArgs e)
        {
            await _currencyDetailViewModel.GetCurrency(CurrencyIdInput.Text);

            CurrencyIDValue.Content = _currencyDetailViewModel.Asset.Asset_id;
            CurrencyNameValue.Content = _currencyDetailViewModel.Asset.Name;
            Change1hValue.Content = _currencyDetailViewModel.Asset.Change_1h;
            Change24hValue.Content = _currencyDetailViewModel.Asset.Change_24h;
            Change7dValue.Content = _currencyDetailViewModel.Asset.Change_7d;
            Volume24Value.Content = _currencyDetailViewModel.Asset.Volume_24h;
            CurrencyDescription.Text = _currencyDetailViewModel.Asset.Description;
        }
    }
}
