using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdejzdyAutobusu.Models
{
    public class Stops
    {
        public IEnumerable<SelectListItem> stops { get; set; }
        public int id { get; set; }
        public string sname { get; set; }
    }
}