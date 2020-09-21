using Food2.Adapter;
using Food2.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Food2.Service
{
    class ProductServices
    {
        //xu li bất đồng bộ
        private Adapters _adapter = new Adapters();
        public async Task<DataImage> TodaySpecial() // function lay data từ api
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(_adapter.TodaySpecial); // truyen vao link api de lay du lieu ve
            
            if(response.StatusCode == HttpStatusCode.OK)
            {
                var stringContent = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<DataImage>(stringContent);

            }
            return null;
        }
    }
}
