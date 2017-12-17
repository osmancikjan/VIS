using Mapper.DataMapper;
using Mapper.SQLMapper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Serialization;

namespace OdejzdyAutobusu.Controllers
{
    public class TimesController : Controller
    {
        public static List<Shedule> times = new List<Shedule>();
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
        [HttpGet]
        public FileResult Download()
        {
            var dir = new System.IO.DirectoryInfo(Server.MapPath("~/App_Data/Users/"));
            // XmlDocument doc = new XmlDocument();
            using (StreamWriter sw = new StreamWriter(dir + Session["UserID"].ToString() + ".txt"))
            {
                sw.WriteLine("Bus \t Smer \t \t \t Odjezd \t Zpozdeni \t Posledni pozice");
                foreach (Shedule item in times)
                {
                    sw.WriteLine(item.bus + "\t" + item.busto + "\t" + item.time + "\t" + item.delay + "\t" + item.last_known);
                }
            }
            return File(dir + Session["UserID"].ToString() + ".txt", "application\text", Session["UserID"].ToString()+".txt");
        }
    }
}