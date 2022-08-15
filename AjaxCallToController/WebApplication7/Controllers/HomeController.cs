using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // GET: /AjaxTest/
        public string getInfo(string firstname, string efternavn)
        {

            return firstname + " " + efternavn + "Added";
        }

        [HttpPost]
        public JsonResult AjaxMethod(string name)
        {
            

            Person person = new Person();
            person.fornavn = name;
            person.efternavn = "Hansen";
            person.alder = 11;
            person.dato = DateTime.UtcNow.ToString();

            return Json(person);

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