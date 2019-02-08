using Glosharp.Models.Users;
using Newtonsoft.Json;

namespace Glosharp.Models.Columns
{
    public class Column
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "position")]
        public int Position { get; set; }

        [JsonProperty(PropertyName = "archived_date")]
        public string ArchivedDate { get; set; }

        [JsonProperty(PropertyName = "created_date")]
        public string CreatedDate { get; set; }

        [JsonProperty(PropertyName = "created_by")]
        public PartialUser CreatedBy { get; set; }
    }
}
