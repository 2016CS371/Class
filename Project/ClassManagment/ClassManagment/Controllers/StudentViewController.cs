using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassManagment.Models;

namespace ClassManagment.Models
{
    public class StudentViewController : Controller
    {
        // GET: StudentView
        ApplicationDbContext db = new ApplicationDbContext();
        [Authorize(Roles ="Student")]
        public ActionResult LectureView()
        {
            List<Lecture> list = db.Lectures.ToList();
            return View(list);
        }

        [Authorize(Roles = "Student")]
        public ActionResult HolidayView()
        {
            List<Holiday> list = db.Holidays.ToList();
            return View(list);
        }

        [Authorize(Roles = "Student")]
        public ActionResult NoticeView()
        {
            List<Notice> list = db.Notices.ToList();
            return View(list);
        }


         
    }
}
