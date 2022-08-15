using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBWebpage.Models
{
    public class Forening
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public Nullable<int> age { get; set; }
        public Nullable<int> MemberShipID { get; set; }
        public Nullable<int> CityID { get; set; }
    }
}