using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace MvcSite
{
	public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
			services.AddMvc();
        }
		
        public void Configure(IApplicationBuilder app)
        {
            app.UseIISPlatformHandler();

			app.UseMvc(routes =>
				routes.MapRoute("default", "{controller}/{action}", new { controller = "home", action = "index" }));
        }
		
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
