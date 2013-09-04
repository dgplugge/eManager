using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eManager.Web.Models;
using eManager.Domain;

namespace eManager.Web.Controllers
{
    public class TeamController : Controller
    {
        private readonly IGameDataSource _db;
        public TeamController(IGameDataSource db)
        {
            _db = db;
        }
        //
        // GET: /Team/
        [HttpGet]
        public ActionResult Create(int gameId)
        {
            var model = new CreateTeamViewModel();
            model.GameId = gameId;

            return View(model);
        }
        [HttpPost]
        public ActionResult Create(CreateTeamViewModel viewModel) 
        {
            if (ModelState.IsValid)
            {
                var game = _db.Games.Single(d => d.Id == viewModel.GameId);
                var team = new Team();
                team.Name = viewModel.Name;
                team.HireDate = viewModel.HireDate;
                game.Teams.Add(team);
                _db.Save();
                return RedirectToAction("detail", "game", new { id = viewModel.GameId });
            }
            return View(viewModel);
        }
    }
}
