using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EposApi.Models
{
    public  class Presale
    {
        public Presale(Receipt receipt, Cashier cashier, Discount discounts, Customer customer, List<Product> products)
        {
            Discounts = new List<Discount>();
            Receipt = receipt;
            Cashier = cashier;
            Discounts.Add(discounts);
            Customer = customer;
            Products = products;
        }

        [JsonProperty("comprobante")]
        public Receipt Receipt { get; set; }

        [JsonProperty("cajero")]
        public Cashier Cashier { get; set; }

        [JsonProperty("descuentos")]
        public List<Discount> Discounts { get; set; }

        [JsonProperty("datosCliente")]
        public Customer Customer { get; set; }

        [JsonProperty("plus")]
        public List<Product> Products { get; set; }
    }
}
