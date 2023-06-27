using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EposApi.Models
{
    public  class PresaleResponse
    {
        [JsonProperty("comprobante")]
        public ReceiptResponse Receipt { get; set; }

        [JsonProperty("datosCliente")]
        public CustomerResponse CustomerData { get; set; }

        [JsonProperty("cajero")]
        public Cashier Cashier { get; set; }

        [JsonProperty("plus")]
        public List<ProductResponse> Products { get; set; }

        [JsonProperty("descuentos")]
        public List<DiscountResponse> Discounts { get; set; }

        [JsonProperty("ivas")]
        public List<TaxResponse> Taxes { get; set; }

        [JsonProperty("finTicket")]
        public FooterTicket FooterTicket { get; set; }
    }
}
