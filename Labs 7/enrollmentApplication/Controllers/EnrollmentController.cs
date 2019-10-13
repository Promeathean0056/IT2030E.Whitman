using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using enrollmentApplication.Models;

namespace enrollmentApplication.Controllers
{
    public class EnrollmentController : Controller
    {
        private EnrollmentDB db = new EnrollmentDB();
        // GET: Enrollment
        public ActionResult Index()
        {
            var enrollments = db.Enrollments.Include(enrollmentApplication => e.Course).Include(e => e.Student)
            return View(enrollments.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Edit()
        {
            return View();
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    
            }
            Enrollment enrollment = db.Enrollments.Find(id)
            if (enrollment == null)
            {
                return HttpNotFound();
            }
            return View(enrollment);
        }
    }
}