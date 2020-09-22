using Food3.Models;
using Food3.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class ShowCart : Page
    {
        public ShowCart()
        {
            this.InitializeComponent();
            getCart();

        }
        public void getCart()
        {
            List<Cart> list = AddCartService.getDataCart();
            GV_Cart.ItemsSource = list;
        }

        private void FIclose_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var id = (GV_Cart.SelectedItem as Cart).id;
            AddCartService.deleteProduct(id);
            getCart();
        }
    }
}
