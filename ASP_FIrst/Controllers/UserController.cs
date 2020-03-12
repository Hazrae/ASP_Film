using ASP_FIrst.Models;
using ModelClient.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_FIrst.Controllers
{
    public class UserController : Controller
    {
        FilmService fs = new FilmService();

        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddUser()
        {
            return View(new UserSignup());
        }

        public ActionResult AddUser(UserSignup u)
        {
            fs.Create(u);
            return View();
        }
    }
}