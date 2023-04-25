using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;
namespace ResumeProject.Controllers
{
    public class TechnologyController : Controller
    {
        DbResumeEntities4 db = new DbResumeEntities4();
        public ActionResult Index()
        {
            var values = db.TblTecnology.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddTechnology()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddTechnology(TblTecnology p)
        {
            db.TblTecnology.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteTechnology(int id)
        {
            var value = db.TblTecnology.Find(id);
            db.TblTecnology.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateTechnology(int id)
        {
            var value = db.TblTecnology.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateTechnology(TblTecnology p)
        {
            var value = db.TblTecnology.Find(p.TecnologyID);
            value.TecnologyTitle = p.TecnologyTitle;
            value.TecnologyValue = p.TecnologyValue;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}