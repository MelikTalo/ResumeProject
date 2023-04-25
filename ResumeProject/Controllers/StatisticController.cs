using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;
namespace ResumeProject.Controllers
{
    public class StatisticController : Controller
    {
        DbResumeEntities4 db = new DbResumeEntities4();
        public ActionResult Index()
        {
            //ViewBag.skillCount = db.TblSkill.Count();
            ViewBag.CountProjeTalebi = db.CountProjeTalebi().FirstOrDefault();
            ViewBag.techonologyCount = db.TblTecnology.Count();
            ViewBag.csharpValue = db.TblTecnology.Where(x => x.TecnologyTitle == "C#").Select(y=>y.TecnologyValue).FirstOrDefault();
            ViewBag.contactCount = db.TblContacT.Count();
            ViewBag.subjectTesekkur = db.TblContacT.Where(x => x.Subject == 1).Count();
            ViewBag.SumTechnologyValue = db.TblTecnology.Sum(x => x.TecnologyValue);
            ViewBag.averageTechnologyValue = db.TblTecnology.Average(x => x.TecnologyValue);
            ViewBag.GetBy3ID = db.TblSkill.Where(x => x.SkillID == 3).Select(y => y.SkillTitle).FirstOrDefault();
            ViewBag.maxTechnologyValue = db.TblTecnology.Max(x => x.TecnologyValue);
            return View();
        }
    }
}