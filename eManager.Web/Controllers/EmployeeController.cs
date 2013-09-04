using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eManager.Web.Models;
using eManager.Domain;

namespace eManager.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IGameDataSource _db;
        public EmployeeController(IGameDataSource db)
        {
            _db = db;
        }
        //
        // GET: /Employee/
        [HttpGet]
        public ActionResult Create(int gameId)
        {
            var model = new CreateEmployeeViewModel();
            model.GameId = gameId;

            return View(model);
        }
        [HttpPost]
        public ActionResult Create(CreateEmployeeViewModel viewModel) 
        {
            if (ModelState.IsValid)
            {
                var game = _db.Games.Single(d => d.Id == viewModel.GameId);
                var employee = new Employee();
                employee.Name = viewModel.Name;
                employee.HireDate = viewModel.HireDate;
                game.Employees.Add(employee);
                _db.Save();
                return RedirectToAction("detail", "game", new { id = viewModel.GameId });
            }
            return View(viewModel);
        }
    }
}
