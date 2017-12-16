using Mapper.DataMapper;
using Mapper.SQLMapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdejzdyAutobusu.Controllers
{
    public class HomeController : Controller
    {
        //public static Stops stopData = new Stops();
        //public static List<Models.Stops> stops = new List<Models.Stops>();
        Models.Stops stops = new Models.Stops();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Stops()
        {
            var som = StopsSQLMapper.GetStops();
            foreach(var item in som)
            {
                stops.stops. item.id
            }
            
            return View();
        }

        [HttpPost]
        public ActionResult Stops(Stops s)
        {
            int id =
            return RedirectToAction("Shedule", "Times", new { id = id });
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}