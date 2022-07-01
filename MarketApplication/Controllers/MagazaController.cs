using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarketApplication.Controllers
{
    public class MagazaController : BaseController
    {
        public ActionResult Index(int id)
        {
            ViewBag.MagazaKategoriler = db.MagazaKategori.ToList();
            var models = db.Magaza
                .Include("Yorumlar")
                .Where(x => x.MagazaKategoriId == id)
                .ToList();
            return View(models);
        }

        public ActionResult Detay(int magazaId)
        {
            var model = db.Magaza
                .Include("Urunler").
                Include("Yorumlar.Kullanici")
                .FirstOrDefault(x => x.MagazaId == magazaId);
            return View(model);
        }
    }
}