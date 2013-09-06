using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eManager.Domain;
using eManager.Web.Infrastructure;

namespace eManager.Web.Controllers
{
    public class HomeController : Controller
    {
        private IGameDataSource _db;

        public HomeController(IGameDataSource db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            var allGames = _db.Games;
            return View(allGames);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
