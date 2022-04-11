using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio.Models.Class;

namespace Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
       // GET: Portfolio
       Context db = new Context();
        public ActionResult Index()
        {
            var deyisen = db.Portfolis.ToList();
            return View(deyisen);
        }
        public ActionResult Create()
        {
            List<SelectListItem> deyer = (from x in db.Categories.ToList()
                                          select new SelectListItem
                                          {
                                              Text = x.CName,
                                              Value = x.Categoriid.ToString()
                                          }).ToList();
            ViewBag.deyisken = deyer;
            return View();
        }
        [HttpPost]
        public ActionResult Create(Portfoli portfoli)
        {
            db.Portfolis.Add(portfoli);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}