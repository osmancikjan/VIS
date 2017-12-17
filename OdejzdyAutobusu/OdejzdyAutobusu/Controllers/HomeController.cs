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
        List<Stops> stops = new List<Stops>();
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Stops()
        {
            stops = StopsSQLMapper.GetStops().ToList();
            ViewBag.zastavky = stops;

            return View();
        }
        
        [HttpPost]
        public ActionResult Stops(Stops s)
        {
            return RedirectToAction("Shedule", "Times", new { stop = s.id});
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}