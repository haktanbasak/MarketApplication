using MarketApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarketApplication.Controllers
{
    [Authorize]
    public class SiparisController : BaseController
    {
        // GET: Siparis
        public ActionResult Index()
        {
            ViewBag.Sepetler = db.Sepet.Include("Urun").ToList();

            return View();
        }

        public ActionResult Detay(int id)
        {
            var model = db.Siparis.Include("Sepetler").Include("siparisStatu").Include("Kullanici").FirstOrDefault(x => x.SiparisId == id);
            return View(model);
        }

        [HttpPost]
        public ActionResult SiparisTamamla(string adres)
        {
            var kullanici = db.Kullanici.FirstOrDefault();

            var sepetler = db.Sepet.Include("Urun").ToList();
            Siparis siparis = new Siparis();
            siparis.Sepetler = sepetler;
            siparis.Tutar = 0.0;

            foreach (var item in sepetler)
            {
                siparis.Tutar += item.SepetTutar;
            }

            if (adres == null)
            {
                siparis.Adres = kullanici.Adres;
            }
            else
            {
                siparis.Adres = adres;
            }

            siparis.KullaniciId = 1;
            siparis.SiparisStatuId = 1;
            db.Siparis.Add(siparis);
            db.Sepet.RemoveRange(sepetler);
            db.SaveChanges();

            return RedirectToAction("Detay", new { id = siparis.SiparisId });
        }
    }
}