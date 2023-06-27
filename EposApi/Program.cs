
using EposApi;
using EposApi.Models;
using EposApi.Util;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;





ReceiptRequest comprobante = new ReceiptRequest();
Cashier cajero = new Cashier();
DiscountRequest descuento = new DiscountRequest();
CustomerRequest cliente = new CustomerRequest();

List<ProductRequest> productos = new List<ProductRequest>();


cajero.Name = "Cajero 1";
cajero.Legajo = 1234;

comprobante.Type = "Factura";

descuento.SubFamily = 99; // Checar de donde viene la familia de descuentos 
descuento.Description = "Descuento Test Hasar ";
descuento.Percentage = (long)-10.00;

cliente.DocumentType = "DNI";
cliente.Address = "1Florencio Terrada 2076";
cliente.Name= "fABIAN BARCA ";
cliente.Number = 223872378;
cliente.Province = "CABA";
cliente.Locality = "Villa del Parque";
cliente.ResponsibleForIVA = "ConsFinal";

productos.Add(new ProductRequest("779279800773", 5));
productos.Add(new ProductRequest("779089500099", 2));
productos.Add(new ProductRequest("36", 1));




Uri u = new Uri(API.Presale);

PresaleRequest pre = new PresaleRequest(comprobante, cajero, descuento, cliente, productos);

string json = JsonConvert.SerializeObject(pre);

Console.WriteLine(json);
var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

HttpClient httpClient = new HttpClient  {
                Timeout = new TimeSpan(0, 0, 60)
            };

RespuestaPreventa respuesta = new RespuestaPreventa();

try
{
    var postResponse = await  httpClient.PostAsync(u, httpContent);
    Console.WriteLine("******************************************************");
    Console.WriteLine("Respuesta del servidor {0}",u.ToString());
    Console.WriteLine("");
    Console.WriteLine("");
    string result = postResponse.Content.ReadAsStringAsync().Result;

    var res = JsonConvert.DeserializeObject<RespuestaPreventa>(result);

    Console.WriteLine(JsonConvert.SerializeObject(res));
    Console.WriteLine("*******************************************************");
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());   
}


//postResponse.EnsureSuccessStatusCode();

Console.WriteLine("Presione una tecla para salir");
Console.Read();
