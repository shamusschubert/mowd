using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mowd.quote.Models
{
    public class RequestModel
    {
        private readonly Guid _id;


        #region props
        [JsonProperty("id")]
        public Guid Id { get { return _id; } }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("mow")]
        public bool Mow { get; set; }

        [JsonProperty("edge")]
        public bool Edge { get; set; }

        [JsonProperty("blow")]
        public bool Blow { get; set; }

        [JsonProperty("pets")]
        public bool Pets { get; set; }

        [JsonProperty("needBy")]
        public DateTime NeedBy { get; set; }

        [JsonProperty("noEarlierThan")]
        [Range(8, 20, ErrorMessage = "No earlier than hour cannot be earlier than 8am local time")]
        public int NoEarlierThan { get; set; }

        [JsonProperty("noLaterThan")]
        [Range(8, 20, ErrorMessage = "No later than hour cannot be later than 8pm local time")]
        public int NoLaterThan { get; set; }

        [JsonProperty("specialInstructions")]
        public string SpecialInstructions { get; set; }
        #endregion

        public RequestModel()
        {
            this._id = Guid.NewGuid();
        }
    }
}