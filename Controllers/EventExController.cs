using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class EventExController : Controller
    {
        // GET: EventEx
        public ActionResult Index()
        {
            //step1-retrive all dept
            ViewBag.EL = DBOperations.getEmp();
            return View();
        }
        //scope of EL is finished
        public ActionResult GetData()
        {
            //int Eno = int.Parse(Request.Form["ddlEmpno"]);
            int Eno = int.Parse(Request.QueryString["Eno"]);
            ViewBag.msg = DBOperations.DelEmp(Eno);
            ViewBag.EL = DBOperations.getEmp();//again assign to get the refresh data after delete
            return View("Index");
        }
    }
}