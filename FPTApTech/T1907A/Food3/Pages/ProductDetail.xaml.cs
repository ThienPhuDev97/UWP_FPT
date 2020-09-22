﻿using Food3.Adapters;
using Food3.Models;
using Food3.Services;
using SQLitePCL;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
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

        private Product Detail
        {
            get;
            set;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Detail = e.Parameter as Product;
        }

        private void BtnLike_Click(object sender, RoutedEventArgs e)
        {
            SQLiteHelper sQLiteHelper = SQLiteHelper.createInstance();

            SQLiteConnection sQLiteConnection = sQLiteHelper.sQLiteConnection;
            var sqlString = "INSERT INTO Products(id,name,image,description,price) VALUES(?,?,?,?,?)";
            var stt = sQLiteConnection.Prepare(sqlString);
            stt.Bind(1, Detail.id);
            stt.Bind(2, Detail.name);
            stt.Bind(3, Detail.image);
            stt.Bind(4, Detail.description);
            stt.Bind(5, Detail.price);
            stt.Step();
            MainPage.contentFrame.Navigate(typeof(LayoutFavorite));
        }

        private void btBack(object sender, RoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }
        }
    }
}
