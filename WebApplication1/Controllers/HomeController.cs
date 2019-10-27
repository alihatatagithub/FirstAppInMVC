using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {


        //public ActionResult Sea()
        //{
        //    StudentsModel db = new StudentsModel();
        //    return View(db.emps);
        //}
        //[HttpPost]
        //public ActionResult Sea(string SearchTerm)
        //{
        //    List<emp> Emps;
        //    StudentsModel db = new StudentsModel();
        //    if (string.IsNullOrEmpty(SearchTerm))
        //    {
        //       Emps= db.emps.ToList();
        //    }
        //    else
        //    {
        //        Emps = db.emps.Where(a => a.fname.StartsWith(SearchTerm)).ToList();
        //    }
        //    return View(Emps);
        //}
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Detials()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult getstd()
        {
            return PartialView();
        }
    }
}