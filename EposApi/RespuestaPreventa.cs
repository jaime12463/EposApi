using EposApi.Models;
using EposApi.Until;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EposApi
{
    public  class RespuestaPreventa
    {
        [JsonProperty("comprobante")]
        public ReceiptResponse Receipt { get; set; }

        [JsonProperty("datosCliente")]
        public CustomerResponse CustomerData { get; set; }

        [JsonProperty("cajero")]
        public Cashier Cajero { get; set; }

        [JsonProperty("plus")]
        public List<ProductResponse> Products { get; set; }

        [JsonProperty("descuentos")]
        public List<DiscountResponse> Discounts { get; set; }

        [JsonProperty("ivas")]
        public List<Iva> Taxes { get; set; }

        [JsonProperty("finTicket")]
        public FinTicket FinTicket { get; set; }
    }




    //public  class ComprobanteResponse
    //{
    //    [JsonProperty("tipo")]
    //    public string Tipo { get; set; }

    //    [JsonProperty("letra")]
    //    public string Letra { get; set; }

    //    [JsonProperty("operacion")]
    //    public long Operacion { get; set; }

    //    [JsonProperty("fechaHoraTransPV")]
    //    public string FechaHoraTransPv { get; set; }

    //    [JsonProperty("numero")]
    //    public string Numero { get; set; }
    //}

    //public  class DatosClienteResponse
    //{
    //    [JsonProperty("tipoDocumento")]
    //    public string TipoDocumento { get; set; }

    //    [JsonProperty("numero")]
    //    [JsonConverter(typeof(ParseStringConverter))]
    //    public long Numero { get; set; }

    //    [JsonProperty("nombre")]
    //    public string Nombre { get; set; }

    //    [JsonProperty("direccion")]
    //    public string Direccion { get; set; }

    //    [JsonProperty("localidad")]
    //    public string Localidad { get; set; }

    //    [JsonProperty("provincia")]
    //    public string Provincia { get; set; }

    //    [JsonProperty("respAnteIva")]
    //    public string RespAnteIva { get; set; }

    //    [JsonProperty("convenioIngBrutos")]
    //    public string ConvenioIngBrutos { get; set; }

    //    [JsonProperty("nroIngBrutos")]
    //    public string NroIngBrutos { get; set; }
    //}

    //public  class DescuentoResponse
    //{
    //    [JsonProperty("descripcion")]
    //    public string Descripcion { get; set; }

    //    [JsonProperty("importe")]
    //    public long Importe { get; set; }

    //    [JsonProperty("porcentaje")]
    //    public long Porcentaje { get; set; }

    //    [JsonProperty("monto")]
    //    public double Monto { get; set; }

    //    [JsonProperty("subfamilia")]
    //    public long Subfamilia { get; set; }
    //}

    public  class FinTicket
    {
        [JsonProperty("articulos")]
        public long Articulos { get; set; }

        [JsonProperty("montoTotal")]
        public double MontoTotal { get; set; }
    }

    public  class Iva
    {
        [JsonProperty("monto")]
        public double Monto { get; set; }

        [JsonProperty("montoIva")]
        public double MontoIva { get; set; }

        [JsonProperty("base")]
        public double Base { get; set; }

        [JsonProperty("impInternos")]
        public double ImpInternos { get; set; }

        [JsonProperty("porcentaje")]
        public double Porcentaje { get; set; }
    }

    //public  class PlusResponse
    //{
    //    [JsonProperty("codigo")]
    //    public string Codigo { get; set; }

    //    [JsonProperty("descripcion")]
    //    public string Descripcion { get; set; }

    //    [JsonProperty("cantidad")]
    //    public long Cantidad { get; set; }

    //    [JsonProperty("prcUnit")]
    //    public double PrcUnit { get; set; }

    //    [JsonProperty("montoTotal")]
    //    public double MontoTotal { get; set; }

    //    [JsonProperty("pesable")]
    //    public bool Pesable { get; set; }

    //    [JsonProperty("ndto")]
    //    public long Ndto { get; set; }

    //    [JsonProperty("selPrice")]
    //    public long SelPrice { get; set; }
    //}



}
