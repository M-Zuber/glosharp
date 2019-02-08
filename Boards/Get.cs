using System;
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
        /// Get all boards
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public async Task<Tuple<bool, string, BoardsCollection>> GetBoardsAsync(Models.Configuration config)
        {
            using(var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://gloapi.gitkraken.com/v1/glo/boards");
                    client.DefaultRequestHeaders.Authorization = 
                        new AuthenticationHeaderValue("Bearer", config.Token);

                    var response = await client.GetAsync("");
                    response.EnsureSuccessStatusCode();
                    var responseString = await response.Content.ReadAsStringAsync();

                    var boards = JsonConvert.DeserializeObject<BoardsCollection>(responseString);

                    return new Tuple<bool, string, BoardsCollection>(true, response.StatusCode.ToString(), boards);
                }
                catch(HttpRequestException httpException)
                {
                    return new Tuple<bool, string, BoardsCollection>(false, httpException.Message, null);
                }
            }
        }

        /// <summary>
        /// Get a single board
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
                    client.BaseAddress = new Uri("https://gloapi.gitkraken.com/v1/glo/boards/");
                    client.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer", config.Token);

                    var response = await client.GetAsync(boardId);
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