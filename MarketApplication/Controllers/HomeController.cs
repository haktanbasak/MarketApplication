using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarketApplication.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            ViewBag.Kategoriler = db.MagazaKategori.ToList();
            ViewBag.UrunKategoriler = db.Kategori.ToList();
            ViewBag.Urunler = db.Urun.ToList();

            
            return View();
        }

        public PartialViewResult Kategoriler()
        {
            ViewBag.Kategoriler = db.MagazaKategori.ToList();
            return PartialView();
        }
    }
}