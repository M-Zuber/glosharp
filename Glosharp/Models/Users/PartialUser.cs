using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Glosharp.Models.Users
{
    public class PartialUser
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
    }
}
