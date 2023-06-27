using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EposApi.Models
{
    public  class Product
    {
        public Product(string productCode , long quantity)
        {
            ProductCode = productCode;
            Quantity = quantity;
        }
        [JsonProperty("codigo")]
        public string ProductCode { get; set; }

        [JsonProperty("cantidad")]
        public long Quantity { get; set; }
    }
}
