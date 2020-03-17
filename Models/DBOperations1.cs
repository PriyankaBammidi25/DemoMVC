using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoMVC.Models
{
    public class DBOperations1
    {
        static DemoEntities D = new DemoEntities();
        public static List<EMPDATA> GetEmp()
        {
            var E = from E1 in D.EMPDATAs
                    select E1;
            return E.ToList();
        }
        public static EMPDATA Display(int empno)
        {
            var E1 = from E2 in D.EMPDATAs
                     where E2.EMPNO == empno
                     select E2;
           EMPDATA E3= E1.First();
            return E3;
        }
        public static List<EMPDATA> GetEmpList(int[] id)
        {
            var e = from l in D.EMPDATAs
                    where id.Contains(l.EMPNO) == true
                    select l;
            return e.ToList();
        }
    }
}