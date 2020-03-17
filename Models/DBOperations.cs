using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DemoMVC.Models
{
    public class DBOperations
    {
        static DemoEntities D = new DemoEntities();
       
        public static string InsertEmp(EMPDATA E1)
        {
            try
            {
                D.EMPDATAs.Add(E1);
                D.SaveChanges();
                
            }
            catch(DbUpdateException E)
            {
                SqlException ex = E.GetBaseException() as SqlException;
                if (ex.Message.Contains("FK__Deptno")) 
                {
                    return "No proper deptno";
                }
                else if(ex.Message.Contains("EMP_PK"))
                {
                    return "Empno should be unique";
                }
                else
                return "Error occurred";
            }
            return "1 row inserted";
        }
        public static List<EMPDATA> GetDept(int Deptno)
        {
            var LE = from L in D.EMPDATAs
                     where L.DEPTNO == Deptno
                     select L;
            return LE.ToList();
        }
        //public static List<EMPDATA> GetData(int Empno)
        //{
        //    var LD= from L in D.EMPDATAs
        //            where L.EMPNO == Empno
        //            select L;
        //    return LD.ToList();
        //}
        public static List<DEPTDATA> getDepts()
        {
            var dept = from D1 in D.DEPTDATAs
                       select D1;
            return dept.ToList();
        }
       public static List<EMPDATA> getEmp()
        {
            var empno = from E in D.EMPDATAs
                        select E;
            return empno.ToList();
        }
        public static string DelEmp(int Empno)
        {
            var empno1 = from E in D.EMPDATAs
                         where E.EMPNO == Empno
                         select E;
            D.EMPDATAs.Remove(empno1.First());//var is of object type
            D.SaveChanges();
            return Empno + " Deleted";
        }
        //extract details of given empno
        public static EMPDATA GetDetails(int Empno)//passing empno and getting the row(all fields)
        {
            var eno = from E in D.EMPDATAs
                      where E.EMPNO == Empno
                      select E;
            //EMPDATA E1 = eno.First();
            return eno.FirstOrDefault();
        }
       
        public static string GetUpdate(int Empno,EMPDATA emp)
        {
            var U = from L in D.EMPDATAs
                    where L.EMPNO == Empno
                    select L;
            foreach(var i in U)
            {
                i.JOB = emp.JOB;
                i.MGR = emp.MGR;
                i.SAL = emp.SAL;
                i.COMM = emp.COMM;
                i.DEPTNO = emp.DEPTNO;
            }
            //or 
           // EMPDATA e = U.First();
           // e.ENAME = emp.ENAME;
            D.SaveChanges();
            return "1 Row updated";
        }
        //to get the data between two records
        public static List<EMPDATA> GetDate(DateTime start,DateTime end)
        {
            var E = from L in D.EMPDATAs
                    where L.HIREDATE >=start && L.HIREDATE <=end
                    select L;
            return E.ToList();
        }
    }
}