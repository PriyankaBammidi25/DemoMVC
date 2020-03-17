using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class BoundController : Controller
    {
        // GET: Bound
        //send empty object from controller to view//goes to display page
        public ActionResult Index()
        {
            Emp E = new Emp();
            return View(E);
        }
        //receiving object from view  to controller
        public ActionResult Display(Emp A)
        {
            return View(A);
        }
        //when we want be in same page 
        public ActionResult Index1()
        {
            Emp E = new Emp();
            return View(E);
        }
        [HttpPost]
        public ActionResult Index1(Emp E)
        {
            return View("Display",E);
        }
        //unbound controls
        public ActionResult UnBound()
        {
            return View();
        }
        public ActionResult ShowData()
        {
            //to extract the values
            Emp E = new Emp();
            E.Empno = int.Parse(Request.Form["txtEmpno"]);
            E.Ename = Request.Form["txtEname"];
            E.Salary = Double.Parse(Request.Form["txtSalary"]);
            return View(E);
        }
    }
}