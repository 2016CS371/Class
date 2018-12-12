using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassManagment.Models;
namespace ClassManagment.Controllers
{
    public class HolidayController : Controller
    {
        // GET: Holiday
        [Authorize(Roles = "Admin")]
        public ActionResult ShowHoliday()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<Holiday> list = db.Holidays.ToList();
            return View(list);
        }

        // GET: Holiday/Details/5
        [Authorize(Roles = "Admin")]
        public ActionResult DetailsHoliday(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var v = db.Holidays.Single(a => a.Holidayid == id);
            return View(v);
        }

        // GET: Holiday/Create
        [Authorize(Roles = "Admin")]
        public ActionResult CreateHoliday()
        {
            return View();
        }

        // POST: Holiday/Create
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult CreateHoliday(Holiday L,FormCollection collection)
        {
            try
            {
                ApplicationDbContext db = new ApplicationDbContext();
                db.Holidays.Add(L);
                db.SaveChanges();

                return RedirectToAction("ShowHoliday");
            }
            catch
            {
                return View();
            }
        }

        // GET: Holiday/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult EditHoliday(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var v = db.Holidays.Single(a => a.Holidayid == id);
            return View(v);
            
        }

        // POST: Holiday/Edit/5
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult EditHoliday(int id, FormCollection collection)
        {
            try
            {
                ApplicationDbContext db = new ApplicationDbContext();
                var v = db.Holidays.Single(a => a.Holidayid == id);
                TryUpdateModel(v);
                db.SaveChanges();
                return RedirectToAction("ShowLecture");
            }
            catch
            {
                return View();
            }
        }

        // GET: Holiday/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteHoliday(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var v = db.Holidays.Single(a => a.Holidayid == id);
            return View(v);
            
        }

        // POST: Holiday/Delete/5
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteHoliday(int id, FormCollection collection)
        {
            try
            {
                ApplicationDbContext db = new ApplicationDbContext();
                var v = db.Holidays.Single(a => a.Holidayid == id);
                db.Holidays.Remove(v);
                db.SaveChanges();
                return RedirectToAction("ShowLecture");
            }
            catch
            {
                return View();
            }
        }
    }
}
