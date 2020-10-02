using Food3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food3.Services
{
    interface AccountServices 
    {
        bool AddDangki(Account item);
        List<CartItem> CheckLogin();

    }
}
