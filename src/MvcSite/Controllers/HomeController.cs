using Microsoft.AspNet.Mvc;

namespace MvcSite.Controllers
{
	public class HomeController : Controller
    {
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
    }
}
