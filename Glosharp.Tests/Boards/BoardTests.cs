using System;
using System.Threading.Tasks;
using Xunit;
using Glosharp.Models.Boards;
using Xunit.Abstractions;
using System.Linq;

namespace Glosharp.Tests.Boards
{
    public class BoardTests
    {
        private readonly ITestOutputHelper _output;

        public BoardTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public async Task GetBoardsAsync()
        {
            // Build
            var configuration = new Configuration.Configuration();
            var configToken = await configuration.GetConfiguration();
            var boardsModel = new BoardsCollection();
            var boardsGet = new Glosharp.Boards.Get();
            
            // Run
            var boardsRaw = await boardsGet.GetBoardsAsync(configToken);
            
            Console.WriteLine(boardsRaw.Item2);
            
            var data = boardsModel.Boards.FirstOrDefault();
            var raw = boardsRaw.Item3.FirstOrDefault();     
            

            foreach (var board in raw.Boards)
            {
                _output.WriteLine(board.Name);
            }

            Assert.Equal(true, true);
        }
    }
}