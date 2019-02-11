using System;
using System.Collections.Generic;
using System.Text;
using Glosharp.Models.Users;
using Newtonsoft.Json;

namespace Glosharp.Models.Attachments
{
    public class Attachment
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }

        [JsonProperty(PropertyName = "mime_type")]
        public string MimeType { get; set; }

        [JsonProperty(PropertyName = "created_date")]
        public string CreatedDate { get; set; }

        [JsonProperty(PropertyName = "created_by")]
        public PartialUser CreatedBy { get; set; }
    }
}
