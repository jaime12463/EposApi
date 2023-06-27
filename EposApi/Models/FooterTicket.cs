using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EposApi.Models
{
    public  class FooterTicket
    {
        [JsonProperty("articulos")]
        public long QuantityProducts { get; set; }

        [JsonProperty("montoTotal")]
        public double Amount { get; set; }
    }
}
