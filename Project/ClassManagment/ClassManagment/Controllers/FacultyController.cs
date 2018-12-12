using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassManagment.Models;

namespace ClassManagment.Controllers
{
    public class FacultyController : Controller
    {
        // GET: Faculty
        [Authorize(Roles = "Admin")]
        public ActionResult ShowFaculty()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<Faculty> list = db.Facultys.ToList();
            return View(list);
        }

        // GET: Faculty/Details/5
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult FacultyDetails(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var d = db.Facultys.Single(a => a.Fid == id);
            return View(d);
            
        }

        // GET: Faculty/Create
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult CreateFaculty()
        {

            return View();
        }

        // POST: Faculty/Create
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult CreateFaculty(Faculty f,FormCollection collection)
        {
            try
            {
                ApplicationDbContext db = new ApplicationDbContext();
                db.Facultys.Add(f);
                db.SaveChanges();

                return RedirectToAction("ShowFaculty");
            }
            catch
            {
                return View();
            }
        }

        [Authorize(Roles = "Admin")]
        public ActionResult EditFaculty(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var v = db.Facultys.Single(a => a.Fid == id);
            return View(v);
        }

        // POST: Faculty/Edit/5
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult EditFaculty(int id, FormCollection collection)
        {
            try
            {
                ApplicationDbContext db = new ApplicationDbContext();
                var v = db.Facultys.Single(a => a.Fid == id);
                TryUpdateModel(v);
                db.SaveChanges();
                return RedirectToAction("ShowFaculty");
            }
            catch
            {
                return View();
            }
        }

        // GET: Faculty/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteFaculty(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var v = db.Facultys.Single(a => a.Fid == id);
            return View(v);
        }

        // POST: Faculty/Delete/5
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteFaculty(int id, FormCollection collection)
        {
            try
            {
                ApplicationDbContext db = new ApplicationDbContext();
                var v = db.Facultys.Single(a => a.Fid == id);
                db.Facultys.Remove(v);
                db.SaveChanges();
                return RedirectToAction("ShowFaculty");
            }
            catch
            {
                return View();
            }
        }
    }
}
