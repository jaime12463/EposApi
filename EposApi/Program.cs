
using EposApi;
using EposApi.Models;
using EposApi.Test;
using EposApi.Util;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;




await PresaleTest.Test();

//postResponse.EnsureSuccessStatusCode();

Console.WriteLine("Presione una tecla para salir");
Console.Read();
