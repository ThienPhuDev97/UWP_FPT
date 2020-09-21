using Food3.Adapters;
using Food3.Models;
using Food3.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Food3.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ProductDetail : Page
    {
        private FoodDetailService service = new FoodDetailService();
        public ProductDetail()
        {
            this.InitializeComponent();
        }

        private Product product { get; set; }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            product = e.Parameter as Product;
            ButtonBack.IsEnabled = this.Frame.CanGoBack;
            Models.ProductDetail p = await service.todaySpecial(product.id);
            product = p.data;

        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }
        }

        private void ClickFavorite(object sender, RoutedEventArgs e)
        {
            MainPage.FavoriteProduct.Add(product);
        }
    }
}
