using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Glosharp.Models.Boards;
using Newtonsoft.Json;

namespace Glosharp.Boards
{
    public class Get
    {
        /// <summary>
        /// Get all boards for the current user.
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public async Task<Tuple<bool, string, List<BoardsCollection>>> GetBoardsAsync(Models.Configuration config, bool archived = false, int page = 1, int perPage = 50, string sort = "asc")
        {
            using(var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri(Constants.BoardEndpoints.Boards());
                    client.DefaultRequestHeaders.Authorization = 
                        new AuthenticationHeaderValue("Bearer", config.Token);

                    var response = await client.GetAsync("");
                    response.EnsureSuccessStatusCode();
                    var responseString = await response.Content.ReadAsStringAsync();

                    var boards = JsonConvert.DeserializeObject<List<BoardsCollection>>(responseString);

                    return new Tuple<bool, string, List<BoardsCollection>>(true, response.StatusCode.ToString(), boards);
                }
                catch(HttpRequestException httpException)
                {
                    return new Tuple<bool, string, List<BoardsCollection>>(false, httpException.Message, null);
                }
            }
        }

        /// <summary>
        /// Get a single board that the user has access to.
        /// </summary>
        /// <param name="config"></param>
        /// <param name="boardId"></param>
        /// <returns></returns>
        public async Task<Tuple<bool, string, Board>> GetBoardAsync(Models.Configuration config, string boardId)
        {
            using(var client = new HttpClient())
            {
                try 
                {
                    client.BaseAddress = new Uri(Constants.Endpoint.Base);
                    client.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer", config.Token);

                    var response = await client.GetAsync(Constants.BoardEndpoints.Board(boardId));
                    response.EnsureSuccessStatusCode();
                    var responseString = await response.Content.ReadAsStringAsync();

                    var board = JsonConvert.DeserializeObject<Board>(responseString);

                    return new Tuple<bool, string, Board>(true, response.StatusCode.ToString(), board);
                }
                catch(HttpRequestException httpException)
                {
                    return new Tuple<bool, string, Board>(false, httpException.Message, null);
                }
            }
        }
    }
}