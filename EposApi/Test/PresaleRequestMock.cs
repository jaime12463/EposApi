using EposApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EposApi.Test
{
    public class PresaleRequestMock
    {
        private PresaleRequestMock() { }
        
        public static PresaleRequest Instance()
        {
            ReceiptRequest receipt = new ReceiptRequest();
            Cashier cashier = new Cashier();
            List<DiscountRequest> discounts = new List<DiscountRequest>();
            DiscountRequest discount = new DiscountRequest();
            CustomerRequest customer = new CustomerRequest();

            List<ProductRequest> products = new List<ProductRequest>();


            cashier.Name = "Cajero 1";
            cashier.Legajo = 1234;

            receipt.Type = "Factura";

            discount.SubFamily = 99; // Checar de donde viene la familia de descuentos 
            discount.Description = "Descuento Test Hasar ";
            discount.Percentage = (long)-10.00;

            customer.DocumentType = "DNI";
            customer.Address = "1Florencio Terrada 2076";
            customer.Name = "fABIAN BARCA ";
            customer.Number = 223872378;
            customer.Province = "CABA";
            customer.Locality = "Villa del Parque";
            customer.ResponsibleForIVA = "ConsFinal";

            products.Add(new ProductRequest("779279800773", 5));
            products.Add(new ProductRequest("779089500099", 2));
            products.Add(new ProductRequest("36", 1));

            discounts.Add(discount);


            return new PresaleRequest(receipt, cashier, discounts, customer, products);

        }
    }
}
