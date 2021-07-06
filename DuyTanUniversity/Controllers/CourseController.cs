using DuyTanUniversity.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace DuyTanUniversity.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        private SchoolContext db = new SchoolContext();
        public ActionResult Index()
        {
            var courses = db.Courses.Include(c => c.Department);
            return View(courses.ToList());
        }
    }
}