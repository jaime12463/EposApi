
using EposApi;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;




Comprobante comprobante = new Comprobante();
Cajero cajero = new Cajero();
Descuento descuento = new Descuento();
DatosCliente cliente = new DatosCliente();

List<Plus> productos = new List<Plus>(); 


cajero.Nombre = "Cajero 1";
cajero.Legajo = 1234;

comprobante.Tipo = "Factura";

descuento.Subfamilia = 99; // Checar de donde viene la familia de descuentos 
descuento.Descripcion = "Descuento Test Hasar ";
descuento.Porcentaje = (long)-10.00;

cliente.TipoDocumento = "DNI";
cliente.Direccion = "1Florencio Terrada 2076";
cliente.Nombre = "fABIAN BARCA ";
cliente.Numero = 223872378;
cliente.Provincia = "CABA";
cliente.Localidad = "Villa del Parque";
cliente.RespAnteIva = "ConsFinal";

productos.Add(new Plus("779279800773", 5));
productos.Add(new Plus("779089500099", 2));
productos.Add(new Plus("36", 1));



string api = "http://10.0.2.62:8081/PreVenta";

Uri u = new Uri(api);

Preventa pre = new Preventa(comprobante, cajero, descuento, cliente, productos, "");

string json = JsonConvert.SerializeObject(pre);

Console.WriteLine(json);
var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
//httpContent.Headers.ContentType=new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
//httpContent.Headers.Remove("Date");
HttpClient httpClient = new HttpClient  {
                Timeout = new TimeSpan(0, 0, 60)
            };
//httpClient.DefaultRequestHeaders.Accept.Clear();
//httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
//httpClient.DefaultRequestHeaders.
//var postResponse = await httpClient.PostAsync(u, httpContent);

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
