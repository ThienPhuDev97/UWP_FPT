using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.ServiceModel.Channels;
using T1907A.Models;
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

namespace T1907A.Layout
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ExampleListView01 : Page
    {
       private List<Contact> contacts = new List<Contact>()
            {
                new Contact("phu",0971072097,"ha noi","laptrinh"),
                new Contact("hanh",0971072097,"ha noi","laptrinh"),
                new Contact("ngocanh",0971072097,"ha noi","laptrinh"),
            };
        public ExampleListView01()
        {
           
            this.InitializeComponent();
            gv.ItemsSource = contacts;
           
           
           
        }

        private void gv_ItemClick(object sender, ItemClickEventArgs e)
        {
            Contact contact = (Contact)e.ClickedItem;
            selectImage.Text = contact.Name;
            
            
        }

        //private void lst_selectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    ListView l1 = sender as ListView;
        //    string selected = l1.SelectedItem.ToString();
        //    l1.Items.Remove(selected);

        //}

    }
}
