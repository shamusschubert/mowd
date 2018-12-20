using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mowd.quote.Models
{
    public class Bid
    {
        [JsonProperty("requestId")]
        public Guid RequestId { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("specialInstructions")]
        public string SpecialInstructions { get; set; }
    }
}
