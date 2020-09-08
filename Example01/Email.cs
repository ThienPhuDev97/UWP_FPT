using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1907A.model
{
    class Email
    {
        public string NameEmail { get; set; }
        public string TieuDe { get; set; }
        public string Content { get; set; }

        public Email(string nameEmail, string tieude, string content)
        {
            this.NameEmail = nameEmail;
            this.TieuDe = tieude;
            this.Content = content;
        }
        public override string ToString()
        {
            return NameEmail + " || " + TieuDe + "  || " + Content;
        }
    }
}
