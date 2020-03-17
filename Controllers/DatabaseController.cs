using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class DatabaseController : Controller
    {
        // GET: Database
        static List<DEPTDATA> L1=null;
        static List<EMPDATA> E1 = null;
        public ActionResult Index()
        {
            EMPDATA E = new EMPDATA();
            return View(E);
        }
        [HttpPost]
        public ActionResult Index(EMPDATA E)
        {
            ViewBag.message=DBOperations.InsertEmp(E);
            return View();
        }
        public ActionResult Display(EMPDATA E)
        {
            return View(E);
        }
        public ActionResult getDeptData()
        {
            return View();
        }
        public ActionResult GetDept()
        {
            int deptno = int.Parse(Request.Form["txtDeptno"]);
            ViewBag.L=DBOperations.GetDept(deptno);
            return View("getDeptData");
        }
        //public ActionResult GetData()
        //{
        //    return View();
        //}
        
        //public ActionResult GetDataDetails()
        //{
        //    int empno = int.Parse(Request.Form["txtEmpno"]);
        //    List<EMPDATA> L = DBOperations.GetData(empno);
        //    return View("getData", L);
        //}
        public ActionResult getDepts()
        {
            //List<DEPTDATA> L = DBOperations.getDepts();
            L1= DBOperations.getDepts();
            ViewBag.DL = L1;
            
            return View();
        }
        public ActionResult SendDept()
        {
            int deptno = int.Parse(Request.QueryString["d"]);
            ViewBag.DL = L1;
            ViewBag.DDL = deptno;
            List<EMPDATA> EL=DBOperations.GetDept(deptno);
            return View("getDepts",EL);
        }
        public ActionResult getEmp()
        {
            E1 = DBOperations.getEmp();
            ViewBag.EL = E1;
            return View();
        }
        public ActionResult SendEmp()
        {
            int Empno = int.Parse(Request.QueryString["e"]);
            ViewBag.EL = L1;
            ViewBag.E2 = Empno;
            List<EMPDATA> EL = DBOperations.getEmp();
            return View("getEmp", EL);
        }
        
        
    }
}