using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;

namespace ResumeProject.Controllers
{
    public class ServiceController : Controller
    {
        DbResumeEntities4 db = new DbResumeEntities4();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialFeature()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialServices()
        {
            var values = db.TblServicess.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialForum()
        {
            return PartialView();
        }

    }
}