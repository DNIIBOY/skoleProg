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
            return View();
        }

        public JsonResult AjaxMethod(string name)
        {
            Person person = new Person();
            using (ForeningEntities entity = new ForeningEntities())
            {
                person = (from r in entity.Person
                    where r.firstName == name
                    select r).FirstOrDefault();
            }

            Person new_person = new Person();
            new_person.firstName = person.firstName;
            new_person.lastName = person.lastName;
            new_person.age = person.age;
            return (Json(new_person));
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