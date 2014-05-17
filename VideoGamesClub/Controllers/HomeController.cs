using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoGamesClub.Models;

namespace VideoGamesClub.Controllers
{
    public class HomeController : Controller
    {
        VideoGamesClubDb db = new VideoGamesClubDb();
        
        public ActionResult Index()
        {
            ViewBag.Message = "Message from HomeController.";
            return View(db.News.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Message from HomeController.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Expand(int id)
        {
            News nw = db.News.ToList()[id];
            if (nw == null)
            {
                return HttpNotFound();
            }
            nw.isCollapsed = !nw.isCollapsed;
            
            return RedirectToAction("Index");
        }
    }
}
