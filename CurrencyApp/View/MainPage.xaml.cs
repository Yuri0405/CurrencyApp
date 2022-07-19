using CurrencyApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private AssetViewModel _assetViewModel;

        public MainPage()
        {
            InitializeComponent();
            _assetViewModel = new AssetViewModel();
        }

        private async void buttonGetCurrencies(object sender, RoutedEventArgs e)
        {
            await _assetViewModel.GetCurrencies();
            CurrencyList.ItemsSource = _assetViewModel.Assets;
        }
    }
}
