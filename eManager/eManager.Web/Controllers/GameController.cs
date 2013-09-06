using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eManager.Domain;
using eManager.Web.Models;

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

        [HttpGet]
        public ActionResult Create(int gameId)
        {
            var model = new CreateGameViewModel();
            model.GameId = gameId;

            return View(model);
        }
        [HttpPost]
        public ActionResult Create(CreateGameViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var team = _db.Teams.Single(d => d.Id == viewModel.GameId);
                var game = new Game();
                game.Venue = viewModel.Venue;
                game.GameTime = viewModel.GameTime;
                game.Home = team;
                _db.Save();
                return RedirectToAction("detail", "game", new { id = viewModel.GameId });
            }
            return View(viewModel);
        }
        public ActionResult Edit(int id)
        {
            var model = new CreateGameViewModel();

            var game = _db.Games.Single(d => d.Id == id);
            model.GameId = game.Id;
            model.GameTime = game.GameTime;
            model.Teams = _db.Teams;
            model.Home = game.Home;

            
            IEnumerable<SelectListItem> items = _db.Teams
              .Select(c => new SelectListItem
              {
                  Value = c.Name,
                  Text = c.Name
              });
            ViewBag.TeamList = items;

            var query = _db.Teams.Select(c => new { c.Id, c.Name });
            ViewBag.TeamList2 = new SelectList(query.AsEnumerable(), "Id", "Name", "3");            
            return View(model);
        }


        public ActionResult Detail(int id)
        {
            var model = _db.Games.Single(d => d.Id == id);
            return View(model);
        }

    }
}
