using ASP_FIrst.Models;
using ASP_FIrst.Utils;
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
        UserService us = new UserService();

        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult User()
        {
            return View(us.GetAll().Select(u=>u.ToLocal()));
        }

        [HttpGet]
        public ActionResult UserAdd()
        {          
                return View(new UserSignup());
        }

        public ActionResult UserAdd(UserSignup u) 
        {
            if (ModelState.IsValid)
            {
                us.Create(u.ToGlobal());
                return RedirectToAction("Index","Home");
                
            }
            else
            {
                return View();
            }
        }

        public ActionResult DeleteUser(int id)
        {
            us.Delete(id);
            return RedirectToAction("User");
        }

        [HttpGet]
        public ActionResult UserEdit(int id)
        {
           UserSignup u = us.GetOne(id).ToLocal();
            return View(u);
        }

        public ActionResult UserEdit(UserSignup u)
        {
            us.UpdateDroits(u.ToGlobal());
            return RedirectToAction("User");
        }

       

    }
}