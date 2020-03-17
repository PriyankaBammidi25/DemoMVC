using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class EmpRadioController : Controller
    {
        // GET: EmpRadio
        static List<EMPDATA> LE = null;
        public ActionResult Index()
        {
            LE = DBOperations1.GetEmp();
            //ViewBag.list = LE; return View();
            return View(LE);
        }
        public ActionResult Display()
        {
            int empno = Convert.ToInt32(Request.Form["rdb"].ToString());
            // EMPDATA E = DBOperations1.Display(empno);
            //return View(E);
            ViewBag.E= DBOperations1.Display(empno);
            return View();
        }
    }
}