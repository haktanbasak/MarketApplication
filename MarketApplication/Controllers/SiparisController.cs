using MarketApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarketApplication.Controllers
{
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
            int kId = Convert.ToInt32(Session["Kullanici"]);
            var kullanici = db.Kullanici.Find(kId);

            var sepetler = db.Sepet.Include("Urun").ToList();
            
            Siparis siparis = new Siparis();

            siparis.SaticiId = 1;

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

            siparis.KullaniciId = kullanici.KullaniciId;
            siparis.SiparisStatuId = 1;
            db.Siparis.Add(siparis);
            db.Sepet.RemoveRange(sepetler);
            db.SaveChanges();

            return RedirectToAction("Detay", new { id = siparis.SiparisId });
        }

        public ActionResult Duzenle(int id)
        {
            var siparis = db.Siparis.Find(id);
            var sipStatuler = db.SiparisStatu.ToList();
            ViewBag.statuler = sipStatuler;
            return View(siparis);
        }
        [HttpPost]
        public ActionResult Duzenle(Siparis sip)
        {
            var siparis = db.Siparis.Find(sip.SiparisId);
            siparis.SiparisStatuId = sip.SiparisStatuId;
            var sipStatuler = db.SiparisStatu.ToList();
            ViewBag.statuler = sipStatuler;
            db.SaveChanges();
            return Redirect("/satici/siparisler");
        }
    }
}