using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T1907A.Models;

namespace T1907A.ViewModel
{
    class ViewModel_Contact
    {
        public static List<Contact> ContactList = new List<Contact>();

        public ViewModel_Contact()
        {
            if (ContactList.Count == 0)
            {
                ContactList.Add(new Models.Contact("phu", 0971072098, "ha noi", "lap trinh"));
                ContactList.Add(new Models.Contact("hanh", 0971072999, "ha noi", "IT"));

            }

        }
        public List<Contact> Contacts
        {
            get => ContactList;
        }
    }
}
