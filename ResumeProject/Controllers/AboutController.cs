using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;

namespace ResumeProject.Controllers
{

    public class AboutController : Controller
    {
        DbResumeEntities4 db = new DbResumeEntities4();
       
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult PartialFeatureD()
        {
            return PartialView();
        }
        public PartialViewResult PartialVideo()
        {
            var value = db.TblVideo.ToList();
            return PartialView(value);
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialHireMe()
        {
            var value = db.TblHireMe.ToList();
            return PartialView(value);
        }
        public PartialViewResult PartialCustomer()
        {
            var value = db.TblCustomer.ToList();
            return PartialView(value);
        }

    }
}