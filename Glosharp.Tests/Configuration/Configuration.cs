using System;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Glosharp.Tests.Configuration
{
    public class Configuration
    {
        public async Task<Models.Configuration> GetConfiguration()
        {
            var config = new Models.Configuration();

            if (File.Exists("config.json"))
            {
                var json = await File.ReadAllTextAsync("config.json");

                var configJson = JsonConvert.DeserializeObject< Models.Configuration>(json);
                config.Token = configJson.Token;

                return config;
            }

            var envToken = Environment.GetEnvironmentVariable("Glosharp-Token", EnvironmentVariableTarget.Machine);
            config.Token = envToken;
            return config;
        }
    }
}
