using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EposApi.Models
{
    public  class PresaleRequest
    {
        public PresaleRequest(ReceiptRequest receipt, Cashier cashier, List<DiscountRequest> discounts, CustomerRequest customer, List<ProductRequest> products)
        {
            Discounts = new List<DiscountRequest>();
            Receipt = receipt;
            Cashier = cashier;
            Discounts=discounts;
            Customer = customer;
            Products = products;
        }

        [JsonProperty("comprobante")]
        public ReceiptRequest Receipt { get; set; }

        [JsonProperty("cajero")]
        public Cashier Cashier { get; set; }

        [JsonProperty("descuentos")]
        public List<DiscountRequest> Discounts { get; set; }

        [JsonProperty("datosCliente")]
        public CustomerRequest Customer { get; set; }

        [JsonProperty("plus")]
        public List<ProductRequest> Products { get; set; }
    }
}
