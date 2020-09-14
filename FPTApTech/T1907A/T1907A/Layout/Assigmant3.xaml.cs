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

namespace T1907A.Layout
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Assigmant3 : Page
    {
        public Assigmant3()
        {
            this.InitializeComponent();
        }

        private void ListView_Loader72(object sender, RoutedEventArgs e)
        {
            //LV.Items.Add(new Contact("phu", 0971072097, "ha noi", "lap trinh"));
            //LV.Items.Add(new Contact("hanh", 0971072097, "ha noi", "lap trinh"));
            LV.Items.Add(new ProductItem((char)(Convert.ToInt32("E80F", 16)), "List Contact", "lst"));
            LV.Items.Add(new ProductItem((char)(Convert.ToInt32("EA4A", 16)), "Add Contact", "add"));
        }





        
    }  
}
