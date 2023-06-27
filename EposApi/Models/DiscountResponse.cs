using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EposApi.Models
{
    public  class DiscountResponse: DiscountRequest
    {
        [JsonProperty("importe")]
        public long SubAmount { get; set; }

        [JsonProperty("monto")]
        public double Amount { get; set; }
    }
}
