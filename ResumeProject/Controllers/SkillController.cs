﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;
namespace ResumeProject.Controllers
{
    public class SkillController : Controller
    {
       DbResumeEntities4 db = new DbResumeEntities4();
        public ActionResult Index()
        {
            var values = db.TblSkill.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSkill(TblSkill p)
        {
            db.TblSkill.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteSkill(int id)
        {
            var value = db.TblSkill.Find(id);
            db.TblSkill.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            var value = db.TblSkill.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateSkill(TblSkill p)
        {
            var value = db.TblSkill.Find(p.SkillID);
            value.SkillTitle = p.SkillTitle;
            value.Skillicon = p.Skillicon;
            value.SkillDescription = p.SkillDescription;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}