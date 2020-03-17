using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class RadioController : Controller
    {
        // GET: Radio
         List<DEPTDATA> L1 = null;
         List<EMPDATA> E1 = null;
        public ActionResult Index()
        {
            L1 = DBOperations.getDepts();
            ViewBag.S = L1;

            return View();
           
        }
        //public ActionResult GetDate()
        //{
        //    DateTime S = DateTime.Parse(Request.Form["txtStartDate"]);
        //    DateTime E = DateTime.Parse(Request.Form["txtEndDate"]);
        //    ViewBag.B = DBOperations.GetDate(S, E);
        //    return View("Index");
        //}
        //public ActionResult getDepts()
        //{
        //    //List<DEPTDATA> L = DBOperations.getDepts();
        //    L1 = DBOperations.getDepts();
        //    ViewBag.DL = L1;

        //    return View();
        //}
        //public ActionResult SendDept()
        //{
        //    int deptno = int.Parse(Request.Form["ddlDeptno"]);
        //    ViewBag.DL = L1;
        //    ViewBag.DDL = deptno;
        //    List<EMPDATA> EL = DBOperations.GetDept(deptno);
        //    return View("getDepts", EL);
        //}
        public ActionResult radiobtn()
        {
            L1 = DBOperations.getDepts();
            ViewBag.S = L1;
            if (Request.Form["txtStartDate"] != null && Request.Form["txtEndDate"] != null)
            {
                DateTime S = DateTime.Parse(Request.Form["txtStartDate"]);
                DateTime E = DateTime.Parse(Request.Form["txtEndDate"]);
                E1 = DBOperations.GetDate(S, E);

                ViewBag.List = E1; return View("Index");
            }
            if (Request.Form["ddlDeptno"] != null)
            {
                int deptno = int.Parse(Request.Form["ddlDeptno"]);
                E1 = DBOperations.GetDept(deptno);
                ViewBag.List = E1;
            }
            return View("Index");
        }
    }
}