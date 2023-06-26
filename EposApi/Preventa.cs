using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonConverter = Newtonsoft.Json.JsonConverter;

namespace EposApi
{
    public class Preventa
    {
         public Preventa(Comprobante comproba, Cajero caje, Descuento descuento, DatosCliente cliente, List<Plus> productos,string text)
        {
            Descuento = new List<Descuento>();
            Comprobante = comproba;
            Cajero = caje;
            Descuento.Add ( descuento);
            DatosCliente = cliente;
            Plus = productos;
        }

        [JsonProperty("comprobante")]
        public Comprobante Comprobante { get; set; }

        [JsonProperty("cajero")]
        public Cajero Cajero { get; set; }

        [JsonProperty("descuentos")]
        public List<Descuento> Descuento { get; set; }

        [JsonProperty("datosCliente")]
        public DatosCliente DatosCliente { get; set; }

        [JsonProperty("plus")]
        public List<Plus> Plus { get; set; }

    }


    public partial class Cajero
    {
        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        [JsonProperty("legajo")]
        [Newtonsoft.Json.JsonConverter(typeof(ParseStringConverter))]
        public long Legajo { get; set; }
    }

    public partial class Comprobante
    {
        [JsonProperty("tipo")]
        public string Tipo { get; set; }
    }

    public partial class DatosCliente
    {
        [JsonProperty("tipoDocumento")]
        public string TipoDocumento { get; set; }

        [JsonProperty("numero")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Numero { get; set; }

        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        [JsonProperty("direccion")]
        public string Direccion { get; set; }

        [JsonProperty("localidad")]
        public string Localidad { get; set; }

        [JsonProperty("provincia")]
        public string Provincia { get; set; }

        [JsonProperty("respAnteIva")]
        public string RespAnteIva { get; set; }
    }

    public partial class Descuento
    {
        [JsonProperty("descripcion")]
        public string Descripcion { get; set; }

        [JsonProperty("porcentaje")]
        public long Porcentaje { get; set; }

        [JsonProperty("subfamilia")]
        public long Subfamilia { get; set; }
    }

    public  class Plus
    {
        public Plus(string codigo ,long cantidad)
        {
            Codigo = codigo;
            Cantidad = cantidad;
        }
        [JsonProperty("codigo")]
        public string Codigo { get; set; }

        [JsonProperty("cantidad")]
        public long Cantidad { get; set; }
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

}
