using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eManager.Domain;

namespace eManager.Web.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameDataSource _db;

        public GameController(IGameDataSource db)
        {
            _db = db;
        }
        // GET: /Game/

        public ActionResult Detail(int id)
        {
            var model = _db.Games.Single(d => d.Id == id);
            return View(model);
        }

    }
}
