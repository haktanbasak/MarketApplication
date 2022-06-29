using MarketApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarketApplication.Controllers
{
    
    public class KullaniciController : BaseController
    {
        Kullanici kullanici;
        public ActionResult Index()
        {
            int kId = Convert.ToInt32(Session["Kullanici"]);
            kullanici = db.Kullanici.Find(kId);

            return View();
        }

        public ActionResult Siparisler()
        {
            int kId = Convert.ToInt32(Session["Kullanici"]);

            var siparisler = db.Siparis
                .Include("siparisStatu")
                .Include("Kullanici")
                .Include("Satici")
                .Include("Satici.Magaza")
                .Include("Sepetler")
                .Where(x => x.KullaniciId == kId);

            return View(siparisler);
        }
    }
}