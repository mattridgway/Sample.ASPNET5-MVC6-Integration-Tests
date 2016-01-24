using Microsoft.AspNet.TestHost;
using System.Net.Http;
using Xunit;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace MvcSite.Test
{
    public class IntegrationTest
    {
        [Fact]
        public async void Returns200()
        {
            var builder = TestServer.CreateBuilder()
                                    .UseEnvironment("Development")
                                    .UseServices(services =>
                                    {
                                        // Change the application environment to the mvc project
                                        var env = new TestApplicationEnvironment();
                                        env.ApplicationBasePath = Path.GetFullPath(Path.Combine(PlatformServices.Default.Application.ApplicationBasePath, "..", "..", "src", "MvcSite"));
                                        env.ApplicationName = "MvcSite";

                                        services.AddInstance<IApplicationEnvironment>(env);
                                    })
                                    .UseStartup<Startup>();
            var server = new TestServer(builder);
            var client = server.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "/");

            var result = await client.SendAsync(request);
            Assert.True(result.StatusCode == System.Net.HttpStatusCode.OK);
        }
    }
}
