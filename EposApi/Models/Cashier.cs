using EposApi.Until;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EposApi.Models
{
    public class Cashier
    {
        [JsonProperty("nombre")]
        public string Name { get; set; }

        [JsonProperty("legajo")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Legajo { get; set; }
    }
}
