using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Glosharp.Models.Users;
using Newtonsoft.Json;
using Glosharp.Models;

namespace Glosharp.Users
{
    public class Get
    {
        /// <summary>
        /// Gets the current authenticated user.
        /// </summary>
        /// <param name="config"><see cref="Configuration"/></param>
        /// <returns></returns>
        public async Task<Tuple<bool, string, User>> GetUserAsync(Configuration config)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri(Constants.Endpoint.Base);
                    client.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer", config.Token);

                    var response = await client.GetAsync(Constants.UserEndpoints.User);
                    response.EnsureSuccessStatusCode();
                    var responseString = await response.Content.ReadAsStringAsync();

                    var user = JsonConvert.DeserializeObject<User>(responseString);

                    return new Tuple<bool, string, User>(true, response.StatusCode.ToString(), user);
                }
                catch (HttpRequestException httpException)
                {
                    return new Tuple<bool, string, User>(false, httpException.Message, null);
                }
            }
                
        }
    }
}
