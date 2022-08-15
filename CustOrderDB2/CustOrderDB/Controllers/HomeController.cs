using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustOrderDB.Models; //Added 

namespace CustOrderDB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            //List with Customer 
            List<Customer> custOrder = new List<Customer>();

            List<CustOrdClass> cuOrClassList = new List<CustOrdClass>();

            //Use the connection for the DB 
            using (CustOrderEntities entitet = new CustOrderEntities())
            {

                //**Searching in 1 table 

                //****Use LINQ - for 1 table
                //custOrder = (from r in entitet.Customer
                //             where r.LastName == "Jensen"
                //             select r).ToList();

                //****Lambda - for 1 table 
                //custOrder = entitet.Customer.Where(x => x.LastName=="Ford" ).ToList();
                //string custOder2 = entitet.Customer.FirstOrDefault(x => x.FirstName == "Gorm" && x.LastName == "Drachmann").ToString();





                //** Searching in tables with a 1 to many relation 

                //LINQ  for 2 tables with one to many relation 
                //cuOrClassList = (from cust in entitet.Customer
                //                 join Order in entitet.Order on cust.ID equals Order.CustomerID
                //                 where cust.LastName.Contains("Jensen")
                //                 select new CustOrdClass { FirstName = cust.FirstName, LastName = cust.LastName, OrderID = Order.ID, Status = Order.Status }).ToList();

                List<Order> custList = entitet.Order.ToList();

                //Lampda for 2 tables with one to many relation 
                cuOrClassList = custList.Where(x => x.Customer.LastName == "Jensen").
                    Select(x => new CustOrdClass
                {
                    FirstName = x.Customer.FirstName,
                    LastName = x.Customer.LastName,
                    OrderID = x.ID,
                    Status = x.Status
                }).ToList();

            }
            return View(cuOrClassList);
        }
     
        public ActionResult IndsætData()
        {
            return View();
        }


        //Fra siden https://www.c-sharpcorner.com/blogs/post-the-data-to-asp-net-mvc-controller-using-jquery-ajax
        [HttpPost]
        public JsonResult IndsætDataPost(Employee employeeData)
        {
            Employee employee = employeeData;

            return Json(employee, JsonRequestBehavior.AllowGet); 
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