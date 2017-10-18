using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DynamicallyLoadingContant.Models;

namespace DynamicallyLoadingContant.Controllers
{
    public class HomeController : Controller
    {
        TestMvcEntities db = new TestMvcEntities();
        public ActionResult Index()
        {
            return View(db.EmployeeInfoes.ToList());
        }

        public ActionResult EmployeeInfo(int id)
        {
            List<EmployeeInfo> EmpInfo = db.EmployeeInfoes.Where(x => x.EmployeeId == id).ToList();
            return View(EmpInfo);
        }
    }
}