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
        private readonly IDepartmentDataSource _db;
        public EmployeeController(IDepartmentDataSource db)
        {
            _db = db;
        }
        //
        // GET: /Employee/
        [HttpGet]
        public ActionResult Create(int departmentId)
        {
            var model = new CreateEmployeeViewModel();
            model.DepartmentId = departmentId;

            return View(model);
        }
        [HttpPost]
        public ActionResult Create(CreateEmployeeViewModel viewModel) 
        {
            if (ModelState.IsValid)
            {
                var department = _db.Departments.Single(d => d.Id == viewModel.DepartmentId);
                var employee = new Employee();
                employee.Name = viewModel.Name;
                employee.HireDate = viewModel.HireDate;
                department.Employees.Add(employee);
                _db.Save();
                return RedirectToAction("detail", "department", new { id = viewModel.DepartmentId });
            }
            return View(viewModel);
        }
    }
}
