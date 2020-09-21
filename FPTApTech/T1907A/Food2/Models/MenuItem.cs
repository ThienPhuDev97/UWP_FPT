using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food2.Models
{
    class MenuItem
    {
        public int id { get; set; }
        public string icon { get; set; }
        public string name { get; set; }

        public int Id { get=>id; set=>id = value; }
        public string Icon { get => icon; set => icon = value; }
        public string Name { get => name; set => name = value; }

        public MenuItem(int id,string icon,string name)
        {
            Id = id;
            Icon = icon;
            Name = name;
        }
    }
}
