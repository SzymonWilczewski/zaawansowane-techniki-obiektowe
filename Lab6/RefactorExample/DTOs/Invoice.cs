using System.Collections.Generic;
using Newtonsoft.Json;

namespace RefactorExample.DTOs
{
    public class Invoice
    {
        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("performance")]
        public List<Performance> Performances { get; set; }
    }
}