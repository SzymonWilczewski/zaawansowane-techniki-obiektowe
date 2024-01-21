using Newtonsoft.Json;

namespace RefactorExample.DTOs
{
    public class Performance
    {
        [JsonProperty("playID")]
        public string PlayID { get; set; }

        [JsonProperty("audience")]
        public int Audience { get; set; }
    }
}