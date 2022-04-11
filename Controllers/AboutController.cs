using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio.Models.Class;

namespace Portfolio.Controllers
{
    public class AboutController : Controller
    {
        Context db = new Context();
        // GET: About
        public ActionResult Index()
        {
            var deyisen = db.Abouts.Where(x => x.Durum == true).ToList();
            return View(deyisen);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(About about)
        {
            about.Durum = true;
            db.Abouts.Add(about);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var delete = db.Abouts.Find(id);
            delete.Durum = false;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Update( int id)
        {
            var deyisen = db.Abouts.Find(id);
            return View("Update", deyisen) ;
        }
        public ActionResult Update1(About about)
        {
            var setr = db.Abouts.Find(about.Aboutid);
            setr.Address = about.Address;
            setr.Available = about.Available;
            setr.Completed = about.Completed;
            setr.Durum = about.Durum;
            setr.Email = about.Email;
            setr.Experience = about.Experience;
            setr.Information = about.Information;
            setr.Name = about.Name;
            setr.Phone = about.Phone;
            setr.Surname = about.Surname;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}