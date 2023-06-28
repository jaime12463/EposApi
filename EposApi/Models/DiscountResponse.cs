using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EposApi.Models
{
    public  class DiscountResponse
    {
        [JsonProperty("descripcion")]
        public string Description { get; set; }

        [JsonProperty("porcentaje")]
        public long Percentage { get; set; }

        [JsonProperty("subfamilia")]
        public long SubFamily { get; set; }
        [JsonProperty("importe")]
        public long SubAmount { get; set; }

        [JsonProperty("monto")]
        public double Amount { get; set; }
    }
}
