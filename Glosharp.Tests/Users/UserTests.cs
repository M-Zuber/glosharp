using System;
using System.Threading.Tasks;
using Xunit;
using Glosharp.Models.Users;
using Xunit.Abstractions;

namespace Glosharp.Tests.Users
{
    public class UserTests
    {
        private readonly ITestOutputHelper _output;

        public UserTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public async Task GetUserData()
        {
            // Build
            var configuration = new Configuration.Configuration();
            var configToken = await configuration.GetConfiguration();
            var userModel = new User();
            var userGet = new Glosharp.Users.Get();
            
            // Run
            var userRaw = await userGet.GetUserAsync(configToken, true);

            userModel.Id = userRaw.Item3.Id;
            userModel.Name = userRaw.Item3.Name;
            userModel.Username = userRaw.Item3.Username;
            userModel.Email = userRaw.Item3.Email;

            // Assert
            // Note: This is for the glosharp@protonmail.com user.
            _output.WriteLine($"Id: {userModel.Id}");
            _output.WriteLine($"Name: {userModel.Name}");
            _output.WriteLine($"Username: {userModel.Username}");
            _output.WriteLine($"Email: {userModel.Email}");
            Assert.Equal("glosharp", userModel.Username);
        }
    }
}
