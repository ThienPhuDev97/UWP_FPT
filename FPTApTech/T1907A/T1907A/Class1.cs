using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace T1907A
{
    class Class1
    {
        public string fullname { get; set; }
        public string phone { get; set; }
        public string age { get; set; }
        public DateTime birthday { get; set; }
        
        public Class1() { }
       public string getdata()
        {
            return "fullname=" + fullname + " age= " + age + " phone= " + phone + " birthday = " + birthday;
        }

    }
}
