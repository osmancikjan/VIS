using Mapper.DataMapper;
using Mapper.SQLMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdejzdyAutobusu.Controllers
{
    public class TimesController : Controller
    {
        List<Times> times = new List<Times>();
        // GET: Times
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Shedule()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Shedule(int stop)
        {
            
            times = TimesSQLMapper.GetTimes(stop).ToList();

            //ViewBag.times = times
            return View(times);
        }
    }
}