using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCV.Models.Entity;

namespace MvcCV.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbCvEntities1 db = new DbCvEntities1();
        public ActionResult Index()
        {
            var Entity = db.About.ToList();
            return View(Entity);
        }
        public PartialViewResult Experience()
        {
            var exp = db.Experience.ToList();
            return PartialView(exp);
        }

        public PartialViewResult Education()
        {
            var Edu= db.Education.ToList();
            return PartialView(Edu);
        }

        public PartialViewResult Skill()
        {
            var Skills = db.Skill.ToList();
            return PartialView(Skills);

        }
        public PartialViewResult Hobbys()
        {
            var Hob = db.Hobby.ToList();
            return PartialView(Hob);
        }

        public PartialViewResult Certifica()
        {
            var Cer = db.Certificate.ToList();
            return PartialView(Cer);
        }


        [HttpGet]
        public PartialViewResult Iletism()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult Iletism(Contact c)
        {
            db.Contact.Add(c);
            db.SaveChanges();
            return PartialView();
        }





    }
}