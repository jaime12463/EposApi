using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EposApi.Models
{
    public class Receipt
    {
        [JsonProperty("tipo")]
        public string Type { get; set; }
    }
}
