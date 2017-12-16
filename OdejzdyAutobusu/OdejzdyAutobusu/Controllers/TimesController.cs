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

     /*   public ActionResult Shedule()
        {
            return View(times);
        }*/
        
        public ActionResult Shedule(string id)
        {
            Int32 newId = Int32.Parse(id);
            times = TimesSQLMapper.GetTimes(newId).ToList();

            //ViewBag.times = times
            return View(times);
        }
    }
}