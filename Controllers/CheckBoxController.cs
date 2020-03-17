using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class CheckBoxController : Controller
    {
        // GET: CheckBox
        List<DEPTDATA> L1 = null;
        List<EMPDATA> E1 = null;
       [HttpGet]
        public ActionResult Index()
        {
            E1 = DBOperations1.GetEmp();
            return View(E1);
        }
        public ActionResult Display(int[] ch)
        {
           // int empno = Convert.ToInt32(Request.Form["chk"].ToString());
            // EMPDATA E = DBOperations1.Display(empno);
            //return View(E);
            E1 = DBOperations1.GetEmpList(ch);
            return View(E1);
        }
       
    }
}