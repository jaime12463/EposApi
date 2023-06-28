using EposApi.Models;
using EposApi.Test;
using EposApi.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EposApi
{
    public  class Presale
    {
        public async Task<PresaleResponse?> Request(PresaleRequest req)
        {
            Uri u = new Uri(API.Presale);

            string json = JsonConvert.SerializeObject(req);

            Console.WriteLine(json);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            HttpClient httpClient = new HttpClient
            {
                Timeout = new TimeSpan(0, 0, 60)
            };

            var postResponse = await httpClient.PostAsync(u, httpContent);

            string result =await postResponse.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<PresaleResponse>(result);

        }
    }
}
