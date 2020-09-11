using System;
using System.Collections;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace T1907A
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        static List<Class1> list = new List<Class1>();
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void AddClick(object sender, RoutedEventArgs e)
        {
            Class1 st = new Class1();
            st.fullname = FullName.Text;
            st.phone = Phone.Text;
            st.age = Age.Text;
            st.birthday = birthday.Date.DateTime;

            LV.Items.Add(st.getdata());
            
           


        }

        private void Age_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
