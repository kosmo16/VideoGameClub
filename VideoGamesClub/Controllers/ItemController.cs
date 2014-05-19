using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoGamesClub.Models;

namespace VideoGamesClub.Controllers
{
    public class ItemController : Controller
    {
        private VideoGamesClubDb db = new VideoGamesClubDb(); // kontekst do bazy

        //
        // GET: /Item/

        public ActionResult Index()
        {
            db.News.ToList();
            return View(db.Games.ToList());
        }

        //
        // GET: /Item/Details/5

        public ActionResult Details(int id = 0)
        {
            Game gm = db.Games.Find(id);
            if (gm == null)
            {
                return HttpNotFound();
            }
            return View(gm);
        }

        //
        // GET: /Item/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Item/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Game gm)
        {
            if (ModelState.IsValid)
            {
                gm.IntroduceDate = DateTime.Now;
                db.Games.Add(gm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gm);
        }

        //
        // GET: /Item/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Game gm = db.Games.Find(id);
            if (gm == null)
            {
                return HttpNotFound();
            }
            return View(gm);
        }

        //
        // POST: /Item/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Game gm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gm).State = EntityState.Modified;
                gm.IntroduceDate = DateTime.Now;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gm);
        }

        //
        // GET: /Item/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Game gm = db.Games.Find(id);
            if (gm == null)
            {
                return HttpNotFound();
            }
            return View(gm);
        }

        //
        // POST: /Item/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Game gm = db.Games.Find(id);
            db.Games.Remove(gm);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}