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

        [HttpGet]
        public ActionResult ChooseSeat(int movieRoomRelationId)
        {
            var service = new MovieService();
            return View(service.GetRoomByRelation(movieRoomRelationId));
        }

        [HttpPost]
        public ActionResult ChooseSeat(int movieRoomRelationId, string seat)
        {
            var service = new MovieService();
            var seatPosition = seat.Split('_');
            if (service.ReserveSeat(1, movieRoomRelationId, int.Parse(seatPosition[0]), int.Parse(seatPosition[1])))
            {
                return RedirectToAction("SeatTaken");
            }

            return RedirectToAction("ChooseSeat", new { movieRoomRelationId });
        }

        [HttpGet]
        public ActionResult SeatTaken()
        {
            return View();
        }
    }
}