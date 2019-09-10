using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DisplayImageInMVC.Models;

namespace DisplayImageInMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index(int id)
        {
            EmployeeEntities employeeEntities = new EmployeeEntities();
            tblEmployee employee = employeeEntities.tblEmployees.Single(x => x.Id == id);

            return View(employee);
        }
    }
}