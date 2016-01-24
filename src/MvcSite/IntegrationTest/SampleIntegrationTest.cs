using Microsoft.AspNet.TestHost;
using System.Net.Http;
using Xunit;

namespace MvcSite.IntegrationTest
{
	public class SampleIntegrationTest
    {
		[Fact]
		public async void Returns200()
		{
			var server = new TestServer(TestServer.CreateBuilder().UseEnvironment("Development").UseStartup<Startup>());
			var client = server.CreateClient();
			var request = new HttpRequestMessage(HttpMethod.Get, "/");

			var result = await client.SendAsync(request);
			Assert.True(result.StatusCode == System.Net.HttpStatusCode.OK);
		}
    }
}
