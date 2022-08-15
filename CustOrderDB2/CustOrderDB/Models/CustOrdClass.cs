using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustOrderDB.Models
{
    public class CustOrdClass
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MobilNumberq { get; set; }

        //Belongs to Order class 
        public int OrderID { get; set; }
        public string Status { get; set; }
    }
}