using ModelClient.Models;
using ModelClient.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_FIrst.Controllers
{
    public class FilmController : Controller
    {
        FilmService fs = new FilmService();
        // GET: Film
        public ActionResult Film()
        {
           return View(fs.GetAll());
        }

        [HttpGet]
        public ActionResult AddFilm()
        {
            return View(new Film());
        }

        public ActionResult AddFilm(Film f)
        {
            fs.Create(f);
            return RedirectToAction("Film");
        }

        public ActionResult Delete(int id)
        {
            fs.Delete(id);
            return RedirectToAction("Film");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            Film filmEdit = fs.GetOne(id);
            return View(filmEdit);
        }

        public ActionResult Update(Film f)
        {
            fs.Update(f);
            return RedirectToAction("Film");
        }

    }
}