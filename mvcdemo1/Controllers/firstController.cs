using mvcdemo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcdemo1.Controllers
{
    public class firstController : Controller
    {
        // GET: first\
        
        public ActionResult Index()
        {
            ViewBag.str = "my first sample";
            ViewData["str1"] = "hello";
            TempData["str2"] = "hi";
            return View();
        }
        public ActionResult SendObject()
        {
            Emp E = new Emp();
            E.Empno = 123;
            E.Ename = "raju";
            E.Salary = 10000;

            return View(E);
        }
        public ActionResult SendObjects()
        {
            List<Emp> L = new List<Emp>();
            Emp E = null;
            E = new Emp();
            E.Empno = 1;
            E.Ename = "raghuu";
            E.Salary = 1000;
            L.Add(E);
            E = new Emp();
            E.Empno = 12;
            E.Ename = "raMuu";
            E.Salary = 12000;
            L.Add(E);

            return View(L);
        }
        public ActionResult SendObject1()
        {
            Emp E = new Emp();
            E.Empno = 123;
            E.Ename = "raju";
            E.Salary = 10000;
            ViewData["xyz"] = E;

            return View();
        }
        public ActionResult SendObject2()
        {
            Emp E = new Emp();
            E.Empno = 123;
            E.Ename = "raju";
            E.Salary = 10000;
            ViewBag.abc = E;

            return View();
        }
        public ActionResult SendObjects3()
        {
            List<Emp> L = new List<Emp>();
            Emp E = null;
            E = new Emp();
            E.Empno = 1;
            E.Ename = "raghuu";
            E.Salary = 1000;
            L.Add(E);
            E = new Emp();
            E.Empno = 12;
            E.Ename = "raMuu";
            E.Salary = 12000;
            L.Add(E);
            ViewData["abc"] = L;

            return View(L);
        }
    }
}