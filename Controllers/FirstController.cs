using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            ViewBag.str = "My First MVC Project";
            ViewData["str1"] = "Second way of assigning";
            TempData["str2"] = "Third way";
            return View();
        }
        public ActionResult SendObject()
        {
            Emp E = new Emp();
            E.Empno = 12;
            E.Ename = "Priya";
            E.Salary = 20000;
            return View(E);
        }
        public ActionResult SendObjects()
        {
            List<Emp> L = new List<Emp>();
            Emp E = null;
            E = new Emp();
            E.Empno = 1;
            E.Ename = "mithra";
            E.Salary = 7000;
            L.Add(E);

            E = new Emp();
            E.Empno = 2;
            E.Ename = "Anitha";
            E.Salary = 8000;
            L.Add(E);
            return View(L);
        }
        public ActionResult SendObjectVB()
        {
            Emp E = null;
            E = new Emp();
            E.Empno = 1;
            E.Ename = "mithra";
            E.Salary = 7000;
            ViewBag.emp = E;
            ViewData["emp1"] = E;
            TempData["emp2"] = E;
            return View();
        }
        public ActionResult SendObjectsVB()
        {
            List<Emp> L = new List<Emp>();
            Emp E = null;
            E = new Emp();
            E.Empno = 1;
            E.Ename = "mithra";
            E.Salary = 7000;
            L.Add(E);

            E = new Emp();
            E.Empno = 2;
            E.Ename = "Anitha";
            E.Salary = 8000;
            L.Add(E);
            ViewBag.emp = L;
            ViewData["empdata"] = L;
            return View();
            
        }
    }
}