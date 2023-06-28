using EposApi.Until;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EposApi.Models
{
    public  class CustomerResponse
    {
        [JsonProperty("tipoDocumento")]
        public string DocumentType { get; set; }

        [JsonProperty("numero")]
        [JsonConverter(typeof(ParseStringConverter))]
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
        [JsonProperty("convenioIngBrutos")]
        public string GrossIngressAgreement { get; set; }

        [JsonProperty("nroIngBrutos")]
        public string GrossIngressNumber { get; set; }
    }
}
