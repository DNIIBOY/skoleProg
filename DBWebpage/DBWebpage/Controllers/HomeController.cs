using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBWebpage.Models;

namespace DBWebpage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List < Person > personList = new List<Person>();
            List < Forening > foreningList = new List<Forening>();


            using (ForeningEntities entity = new ForeningEntities())
            {
                personList = (from r in entity.Person
                              // where r.age == 18
                              select r).ToList();

            }
            return View(personList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}