using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class ValidatonController : Controller
    {
        // GET: Validaton
        public ActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        public ActionResult GetBack(Validation V)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Addpage");
            }
            return View("Index");
        }
        public ActionResult Addpage()
        {
            return View();
        }
    }
}