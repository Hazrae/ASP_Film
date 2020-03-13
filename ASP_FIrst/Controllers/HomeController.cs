using ASP_FIrst.Models;
using ModelClient.Models;
using ModelClient.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_FIrst.Controllers
{
    public class HomeController : Controller
    {
        UserService us = new UserService();
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

        [HttpGet]
        public ActionResult Login()
        {            
            return View(new UserSignup());
        }

        public ActionResult Login(UserSignup u)
        {
            User login = us.GetAll().Where(x => x.Login == u.Login).FirstOrDefault();
            if (login is null)
            {
                ModelState.AddModelError(string.Empty, "le login n'existe pas connard");
                return View(u);
            }
            else
            {
                if (login.Pwd != u.Pwd)
                {
                    ModelState.AddModelError(string.Empty, "le password ne correspond pas connard");
                    return View(u);
                }
                else
                {
                    Session["Actif"] = "True";
                    Session["Admin"] = u.IsAdmin.ToString();        
                }
            }

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Deconnexion()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }


    }
}