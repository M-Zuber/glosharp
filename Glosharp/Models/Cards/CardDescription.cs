using System;
using System.Collections.Generic;
using System.Text;
using Glosharp.Models.Users;
using Newtonsoft.Json;

namespace Glosharp.Models.Cards
{
    public class CardDescription
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        [JsonProperty(PropertyName = "created_date")]
        public string CreatedDate { get; set; }

       [JsonProperty(PropertyName = "updated_date")]
        public string UpdatedDate { get; set; }

        [JsonProperty(PropertyName = "created_by")]
        public PartialUser CreatedBy { get; set; }

        [JsonProperty(PropertyName = "updated_by")]
        public PartialUser UpdatedBy { get; set; }
    }
}
