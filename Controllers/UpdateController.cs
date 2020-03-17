using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class UpdateController : Controller
    {
        // GET: Update
        public ActionResult Index()
        {
            //ViewBag.UL = DBOperations.getEmp();
            return View();
        }
        public ActionResult GetData()
        {
            int Eno = int.Parse(Request.QueryString["Eno"]);
            // ViewBag.EL = DBOperations.getEmp();
            EMPDATA GetDetails = DBOperations.GetDetails(Eno);
            return View("Index", GetDetails);
        }
       
        public ActionResult Update(EMPDATA E)
        {
            int empno = int.Parse(Request.Form["EMPNO"]);
            string s = DBOperations.GetUpdate(empno, E);
            ViewBag.msg = s;
            return View("Index");
        }

    }
}