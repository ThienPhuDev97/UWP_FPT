﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food2.Adapter
{
    class Adapters
    {
        private string baseURL = "https://foodgroup.herokuapp.com";

        public string TodaySpecial
        {
            get => String.Format(baseURL + "/api/today-special");
        }
    }
}
