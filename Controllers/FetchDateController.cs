using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class FetchDateController : Controller
    {
        // GET: FetchDate
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetDate()
        {
            DateTime S = DateTime.Parse(Request.Form["txtStartDate"]);
            DateTime E = DateTime.Parse(Request.Form["txtEndDate"]);
            ViewBag.B = DBOperations.GetDate(S, E);
            return View("Index");
        }
    }
}