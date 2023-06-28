using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EposApi.Models
{
    public class ProductResponse 
    {
       

        [JsonProperty("codigo")]
        public string ProductCode { get; set; }

        [JsonProperty("cantidad")]
        public long Quantity { get; set; }

        [JsonProperty("descripcion")]
        public string Description { get; set; }

        [JsonProperty("prcUnit")]
        public double UnitPrice { get; set; }

        [JsonProperty("montoTotal")]
        public double TotalAmount { get; set; }

        [JsonProperty("pesable")]
        public bool IsWeighable { get; set; }

        [JsonProperty("ndto")]
        public long Ndto { get; set; }

        [JsonProperty("selPrice")]
        public long SelPrice { get; set; }

    }
}
