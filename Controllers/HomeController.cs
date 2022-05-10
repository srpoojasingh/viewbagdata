using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBagD.Models;

namespace ViewBagD.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "This is Pooja";
            ViewBag.List = new List<string>
            {
                "Pooja",
                "Ravi"
            };
            string[] str = { "p", "o", "o", "j", "a" };
            ViewBag.Array= str;
            Employee emp = new Employee();
            emp.EmpId = 1;
            emp.EmpName = "Pooja";
            emp.EmpSal = 30000;
            ViewBag.Employee = emp;
            ViewBag.CommonMessage = "Achieved By ViewData";
            ViewData["Common"] = "Achieved Common By ViewBag";

            return View();
        }

       
    }
}