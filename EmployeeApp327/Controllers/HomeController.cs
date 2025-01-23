using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeApp327.Models;
namespace EmployeeApp327.Controllers
{
    public class HomeController : Controller
    {
        private EmployeeDBContext db = new EmployeeDBContext();
        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}