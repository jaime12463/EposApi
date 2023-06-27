using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EposApi.Models
{
    public  class Customer
    {
        [JsonProperty("tipoDocumento")]
        public string DocumentType { get; set; }

        [JsonProperty("numero")]
       
        public long Number { get; set; }

        [JsonProperty("nombre")]
        public string Name { get; set; }

        [JsonProperty("direccion")]
        public string Address { get; set; }

        [JsonProperty("localidad")]
        public string Locality { get; set; }

        [JsonProperty("provincia")]
        public string Province { get; set; }

        [JsonProperty("respAnteIva")]
        public string ResponsibleForIVA { get; set; }
    }
}
