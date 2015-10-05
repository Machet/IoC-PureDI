using System;
using System.Web.Mvc;

using PureCinema.Business;

namespace PureCinema.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			var service = new MovieService();
			return View(service.GetMovies(DateTime.Now));
		}
	}
}