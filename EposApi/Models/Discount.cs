using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EposApi.Models
{
    public  class Discount
    {
        [JsonProperty("descripcion")]
        public string Description { get; set; }

        [JsonProperty("porcentaje")]
        public long Porcentage { get; set; }

        [JsonProperty("subfamilia")]
        public long SubFamily { get; set; }
    }
}
