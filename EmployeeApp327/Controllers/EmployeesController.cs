using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeApp327.Models;

namespace EmployeeApp327.Controllers
{
    public class EmployeesController : Controller
    {
        private EmployeeDBContext db = new EmployeeDBContext();
        // GET: Employees
        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }
    }
}