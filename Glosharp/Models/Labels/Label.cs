using System;
using Glosharp.Models.Users;
using Newtonsoft.Json;

namespace Glosharp.Models.Labels
{
    public class Label
    {
        [JsonProperty(PropertyName = "id")]
        public string Id {get;set;}

        [JsonProperty(PropertyName = "name")]
        public string Name {get;set;}

        [JsonProperty(PropertyName = "color")]
        public LabelColor Color {get;set;}

        [JsonProperty(PropertyName = "created_date")]
        public DateTime CreatedDate {get;set;}

        [JsonProperty(PropertyName = "created_by")]
        public PartialUser CreatedBy {get;set;}
    }
}