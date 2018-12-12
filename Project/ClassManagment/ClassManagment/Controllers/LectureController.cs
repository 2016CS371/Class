using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassManagment.Models;

namespace ClassManagment.Controllers
{
    public class LectureController : Controller
    {
        // GET: Lecture
        [Authorize(Roles = "Admin")]
        public ActionResult ShowLecture()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<Lecture> list = db.Lectures.ToList();
            return View(list);
        }

        // GET: Lecture/Details/5
        [Authorize(Roles = "Admin")]
        public ActionResult DetailsLecture(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var d = db.Lectures.Single(a => a.Lid == id);
            return View(d);
        }

        // GET: Lecture/Create
        public ActionResult CreateLecture()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var f = db.Facultys.ToList();
            var viewModel = new Lecture
            {
                faculty = f
            };
            return View(viewModel);
        }

        // POST: Lecture/Create
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult CreateLecture(Lecture L,FormCollection collection)
        {
            try
            {

                ApplicationDbContext db = new ApplicationDbContext();
                db.Lectures.Add(L);
                db.SaveChanges();

                return RedirectToAction("ShowLecture");
            }
            catch
            {
                return View();
            }
        }

        // GET: Lecture/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Lecture/Edit/5
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Lecture/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Lecture/Delete/5
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
