using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Vibes.Web.Context;
using Vibes.Web.Models;

namespace Vibes.Web.Controllers
{
    public class MeController : Controller
    {
        private VibesContext db = new VibesContext();
        // GET: Me
        public ActionResult Index()
        {
            return View(db.Posts.ToList());
        }

        // GET: Me/Details/5
        public ActionResult Details(int id)
        {
            if (id==null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Post post = db.Posts.Find(id);
            if (post == null)
                return HttpNotFound();
            return View(post);
        }

        // GET: Me/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Me/Create
        [HttpPost]
        public ActionResult Create(Post post)
        {
            try
            {
                if (ModelState.IsValid) {
                    db.Posts.Add(post);
                    db.SaveChanges();
                    return RedirectToAction("index");
                }

                return View(post);
            }
            catch
            {
                return View();
            }
        }

        // GET: Me/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Post post = db.Posts.Find(id);
            if (post == null)
                return HttpNotFound();

            return View(post);
        }

        // POST: Me/Edit/5
        [HttpPost]
        public ActionResult Edit(Post post)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    db.Entry(post).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(post);
            }
            catch
            {
                return View();
            }
        }

        // GET: Me/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Post post = db.Posts.Find(id);
            if (post == null)
                return HttpNotFound();

            return View(post);
        }

        // POST: Me/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id, Post post)
        {
            try
            {
                // TODO: Add delete logic here
                post = db.Posts.Find(id);
                if (ModelState.IsValid)
                {

                    if (post == null)
                        return HttpNotFound();

                    db.Posts.Remove(post);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(post);
            }
            catch
            {
                return View();
            }
        }
    }
}
