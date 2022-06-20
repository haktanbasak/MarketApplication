using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarketApplication.Controllers
{
    public class MagazaController : BaseController
    {
        public ActionResult Index()
        {
            ViewBag.MagazaKategoriler = db.MagazaKategori.ToList();
            var models = db.Magaza.ToList();
            return View(models);
        }

        public ActionResult Detay(int magazaId)
        {
            var model = db.Magaza.Find(magazaId);
            return View(model);
        }
    }
}