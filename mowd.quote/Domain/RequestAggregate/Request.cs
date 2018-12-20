using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mowd.quote.Domain.RequestAggregate;

namespace mowd.quote.Models
{
    public class Request
    {
        private readonly Guid _id;

        #region props
        [JsonProperty("id")]
        public Guid Id { get { return _id; } }

        [JsonProperty("address")]
        public Address Address { get; private set; }

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

        public Request(Address address, string phone, bool mow, bool edge, bool blow, bool pets, DateTime needBy, int noEarlierThan, int noLaterThan, string specialInstructions)
        {
            this._id = Guid.NewGuid();
            Address = address;
            Phone = phone;
            Mow = mow;
            Edge = edge;
            Blow = blow;
            Pets = pets;
            NeedBy = needBy;
            NoEarlierThan = noEarlierThan;
            NoLaterThan = noLaterThan;
            SpecialInstructions = specialInstructions;
        }
    }
}