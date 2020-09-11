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

namespace T1907A.Layout
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ExampleListView01 : Page
    {
        public ExampleListView01()
        {
            this.InitializeComponent();
            string[] colors = { "red", "blue", "gray" };
            ls1.ItemsSource = colors;
        }

        private void lst_selectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListView l1 = sender as ListView;
            string selected = l1.SelectedItem.ToString();
        }
    }
}
