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
        static List<News> NewsList;

  
        
        public ActionResult Index()
        {
            NewsList = new List<News>();
            News News = new News();
            News.HeadTitle = "Lorem ipsum";
            News.Id = 0;
            News.isCollapsed = false;
            News.Source = "http://www.google.com";
            News.Author = "Józef Dżugaszwili";
            News.ShortText = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.";
            News.FullText = News.ShortText + " Proin nibh augue, suscipit a, scelerisque sed, lacinia in, mi. Cras vel lorem. Etiam pellentesque aliquet tellus. Phasellus pharetra nulla ac diam. Quisque semper justo at risus. Donec venenatis, turpis vel hendrerit interdum, dui ligula ultricies purus, sed posuere libero dui id orci. Nam congue, pede vitae dapibus aliquet, elit magna vulputate arcu, vel tempus metus leo non est. Etiam sit amet lectus quis est congue mollis. Phasellus congue lacus eget neque. Phasellus ornare, ante vitae consectetuer consequat, purus sapien ultricies dolor, et mollis pede metus eget nisi. Praesent sodales velit quis augue. Cras suscipit, urna at aliquam rhoncus, urna quam viverra nisi, in interdum massa nibh nec erat.";

            News News0 = new News();
            News0.HeadTitle = News.HeadTitle;
            News0.Id = 1;
            News0.isCollapsed = true;
            News0.Source = News.Source;
            News0.Author = News.Author;
            News0.ShortText = News.ShortText;
            News0.FullText = News.FullText;

            News News1 = new News();
            News1.HeadTitle = News.HeadTitle;
            News1.Id = 2;
            News1.isCollapsed = true;
            News1.Source = News.Source;
            News1.Author = News.Author;
            News1.ShortText = News.ShortText;
            News1.FullText = News.FullText;

            NewsList.Add(News);
            NewsList.Add(News0);
            NewsList.Add(News1);

            ViewBag.Message = "Message from HomeController.";
            return View(NewsList);
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
            News nw = NewsList[id];
            if (nw == null)
            {
                return HttpNotFound();
            }
            nw.isCollapsed = !nw.isCollapsed;
            
            return RedirectToAction("Index");
        }
    }
}
