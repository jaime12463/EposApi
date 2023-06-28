using EposApi.Models;
using EposApi.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EposApi.Test
{
    public static  class PresaleTest
    {
        public static async Task Test()
        {
            try
            {
                var response =await new Presale().Request(PresaleRequestMock.Instance());
                Console.WriteLine("******************************************************");
                Console.WriteLine("Respuesta del servidor {0}",API.Presale);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(JsonConvert.SerializeObject(response));
                Console.WriteLine("*******************************************************");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

           
        }
    }
}
