using Mapper.DataMapper;
using OdejzdyAutobusu.Models;
using Mapper.DB;
using Mapper.SQLMapper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdejzdyAutobusu.Controllers
{
    public class UsersController : Controller
    {
        public List<Models.Users> users = new List<Models.Users>();
        // GET: Users
        public ActionResult Index()
        {
            return View(UsersSQLMapper.GetUsers().ToList());
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Models.Users user)
        {
            var usr = Mapper.SQLMapper.UsersSQLMapper.Role(user.email, user.pwd, 'U').FirstOrDefault();
            if (usr != null)
            {
                Session["UserID"] = usr.id.ToString();
                Session["Email"] = usr.email.ToString();
                Session["Name"] = usr.firstname.ToString();
                Session["LastName"] = usr.lastname.ToString();
                return RedirectToAction("LoggedIn");
            }
            else
            {
                ModelState.AddModelError("", "Email or password incorrected.");
            }
            return View();
        }

        public ActionResult LoggedIn()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Logout()
        {
            Session.RemoveAll();
            return RedirectToAction("Index", "Home");
        }
    }
}