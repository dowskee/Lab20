using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestASPForms.Models;

namespace TestASPForms.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult SaveUserInfo(UserInfo U)
        {
            ViewBag.UName = U.FirstName;
            //to do: Save user info to DB!
            return View("Confirm");

        }

        public ActionResult Register()
        {
            return View("Register");
        }
    }
}