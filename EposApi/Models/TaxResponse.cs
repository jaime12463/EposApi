using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EposApi.Models
{
    public  class TaxResponse
    {
        [JsonProperty("monto")]
        public double Amount { get; set; }

        [JsonProperty("montoIva")]
        public double IvaAmount { get; set; }

        [JsonProperty("base")]
        public double Base { get; set; }

        [JsonProperty("impInternos")]
        public double InternalTax { get; set; }

        [JsonProperty("porcentaje")]
        public double Percentage { get; set; }
    }
}
