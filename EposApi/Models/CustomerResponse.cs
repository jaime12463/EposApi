using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EposApi.Models
{
    public  class CustomerResponse:CustomerRequest
    {
        [JsonProperty("convenioIngBrutos")]
        public string GrossIngressAgreement { get; set; }

        [JsonProperty("nroIngBrutos")]
        public string GrossIngressNumber { get; set; }
    }
}
