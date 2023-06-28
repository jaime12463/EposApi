using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EposApi.Models
{
    public  class ReceiptResponse
    {
        [JsonProperty("tipo")]
        public string Type { get; set; }
        [JsonProperty("letra")]
        public string Letter { get; set; }

        [JsonProperty("operacion")]
        public long Operation { get; set; }

        [JsonProperty("fechaHoraTransPV")]
        public string DateAndHourTransPv { get; set; }

        [JsonProperty("numero")]
        public string Number { get; set; }
    }
}
