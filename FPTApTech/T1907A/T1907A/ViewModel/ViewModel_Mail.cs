using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T1907A.Models;

namespace T1907A.ViewModel
{
    class ViewModel_Mail
    {
        public static List<Mail> MailList = new List<Mail>();

        public ViewModel_Mail()
        {
            if(MailList.Count == 0)
            {
                MailList.Add(new Models.Mail("phudepzai", "thumoi", "description"));
                MailList.Add(new Models.Mail("smileahjhj", "ansang", "description"));

            }

        }
        public List<Mail> Mails
        {
            get => MailList;
        }
    }
}
