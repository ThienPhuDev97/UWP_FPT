using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using T1907A.Models;
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

namespace T1907A.Layout.BT03
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ListContact : Page
    {
        public ListContact()
        {
            this.InitializeComponent();
        }

        private void GV_Loaded(object sender, RoutedEventArgs e)
        {
            LV.Items.Add(new Contact("phu", 0971078123, "ha noi", "laptrinh"));
            LV.Items.Add(new Contact("hanh", 0971078123, "ha noi", "laptrinh"));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void addContact(object sender, RoutedEventArgs e)
        {
            Home.contentFrame.Navigate(typeof(Add_Contact));
        }
    }
}
