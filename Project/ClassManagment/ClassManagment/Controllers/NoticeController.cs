using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassManagment.Models;
namespace ClassManagment.Controllers
{
    public class NoticeController : Controller
    {
        // GET: Notice
        ApplicationDbContext db = new ApplicationDbContext();

        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            List<Notice> list = db.Notices.ToList();
            return View(list);
        }


        [Authorize(Roles = "Admin")]
        // GET: Notice/Details/5
        public ActionResult Details(int id)
        {
            var d = db.Notices.Single(a => a.Eventid == id);
            return View(d);
        }

        // GET: Notice/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {

            return View();
        }

        // POST: Notice/Create
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Create(Notice n,FormCollection collection)
        {
            try
            {
                db.Notices.Add(n);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Notice/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id)
        {
            var d = db.Notices.Single(a => a.Eventid == id);
            return View(d);
            
        }

        // POST: Notice/Edit/5
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                var d = db.Notices.Single(a => a.Eventid == id);
                TryUpdateModel(d);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Notice/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id)
        {
            var d = db.Notices.Single(a => a.Eventid == id);
            return View(d);
            
        }

        // POST: Notice/Delete/5
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var d = db.Notices.Single(a => a.Eventid == id);
                db.Notices.Remove(d);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
