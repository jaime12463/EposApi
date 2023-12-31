﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EposApi.Models
{
    public  class DiscountRequest
    {
        [JsonProperty("descripcion")]
        public string Description { get; set; }

        [JsonProperty("porcentaje")]
        public long Percentage { get; set; }

        [JsonProperty("subfamilia")]
        public long SubFamily { get; set; }
    }
}
