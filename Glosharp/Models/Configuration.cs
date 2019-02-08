using Newtonsoft.Json;

namespace Glosharp.Models
{
    /// <summary>
    /// Configuration
    /// </summary>
    public class Configuration
    {
        /// <summary>
        /// Personal Access Token
        /// </summary>
        /// <value></value>
        [JsonProperty(PropertyName = "token")]
        public string Token { get; set; }
    }
}