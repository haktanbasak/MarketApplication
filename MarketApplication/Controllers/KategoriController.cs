using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarketApplication.Controllers
{
    public class KategoriController : BaseController
    {
        // GET: Kategori
        public ActionResult Index()
        {
            var degerler = db.Kategori.ToList();
            return View(degerler);
        }

        public ActionResult KategoriUrun(int id)
        {
            var urunler = db.Urun.Where(x=>x.KategoriId == id).ToList();
            return View(urunler);
        }
    }
}