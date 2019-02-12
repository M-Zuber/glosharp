using System;
using System.Net;
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
                    var url = Constants.UserEndpoints.UserFull();
                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer", config.Token);

                    var response = await client.GetAsync("");
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

        /// <summary>
        /// Gets the current user in Partial User format.
        /// </summary>
        /// <param name="config"><see cref="Configuration"/></param>
        /// <remarks>The Tuple contains the full return of this function.</remarks>
        /// <returns><see cref="Boolean"/>True: Successful call</returns>
        /// <returns><see cref="String"/>Status code or exception of the call</returns>
        /// <returns><see cref="PartialUser"/>PartialUser Class</returns>
        public async Task<Tuple<bool, string, PartialUser>> GetUserPartialAsync(Configuration config)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var url = Constants.UserEndpoints.User();
                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer", config.Token);

                    var response = await client.GetAsync("");
                    response.EnsureSuccessStatusCode();
                    var responseString = await response.Content.ReadAsStringAsync();

                    var user = JsonConvert.DeserializeObject<PartialUser>(responseString);

                    return new Tuple<bool, string, PartialUser>(true, response.StatusCode.ToString(), user);
                }
                catch (HttpRequestException httpException)
                {
                    return new Tuple<bool, string, PartialUser>(false, httpException.Message, null);
                }
            }
        }

    }
}
