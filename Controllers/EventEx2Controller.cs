using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class EventEx2Controller : Controller
    {
        //with submit button
        // GET: EventEx2
        public ActionResult Index()
        {
            ViewBag.El = DBOperations.getEmp();//geting all empno's
            return View();
        }
        public ActionResult DelEmp()
        {
            int eno = int.Parse(Request.Form["ddlEmpno"]);
            ViewBag.msg = DBOperations.DelEmp(eno);
            ViewBag.EL = DBOperations.getEmp();
            return View("Index");
        }
    }
}