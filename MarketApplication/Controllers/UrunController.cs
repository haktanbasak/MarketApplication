using MarketApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarketApplication.Controllers
{
    public class UrunController : BaseController
    {
        public ActionResult Index(int UrunId)
        {
            var urun = db.Urun.Find(UrunId);
            return View();
        }

        public ActionResult Detay(int UrunId)
        {
            var urun = db.Urun
                .Include("Yorumlar.Kullanici")
                .FirstOrDefault(x=>x.UrunId == UrunId);
            return View(urun);
        }

        public string sepetEkle(int id,int adet)
        {
            var _kontrolSepet = db.Sepet.FirstOrDefault(x => x.UrunId == id);

            if(_kontrolSepet != null)
            {
                _kontrolSepet.Adet += adet;
                db.SaveChanges();
                return "sepet güncellendi";

            }

            var urun = db.Urun.Find(id);
            Sepet sepet = new Sepet();

            sepet.Adet = adet;
            sepet.isAktif = true;
            sepet.UrunId = id;

            db.Sepet.Add(sepet);
            db.SaveChanges();
            return "işlem başarılı";
        }





    }
}