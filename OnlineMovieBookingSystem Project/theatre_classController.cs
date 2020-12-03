using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Onlinemoviesystem.Models;

namespace Onlinemoviesystem.Controllers
{
    public class theatre_classController : Controller
    {
        online_movie_theatreEntities db = new online_movie_theatreEntities();

        public ActionResult Search_Menu()
        {
            return View();
        }
        public ActionResult SearchMovie()
        {

            return View();
        }
        [HttpPost]
        public ActionResult SearchMovie(theatre_class theatre)
        {
            if (db.theatre_classes.Any(x => x.Movie == theatre.Movie && x.Theatre_City == theatre.Theatre_City))
                ViewBag.Message = "Enjoy the Movie";
            else
                ViewBag.Notification = "This Movie is not play in this theater";
            return View();
        }

        public ActionResult Search_Screen()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Search_Screen(theatre_class theatre)
        {
            {
                if (db.theatre_classes.Any(x => x.List_Of_Screens == theatre.List_Of_Screens && x.Theatre_ID == theatre.Theatre_ID))
                    ViewBag.Message1 = "Enjoy the movie within your wanted screen";
                else
                    ViewBag.Notification1 = "No such screen type is available in this theatre";
                return View();
            }
        }
    }
}
