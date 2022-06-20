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
            var urun = db.Urun.Find(UrunId);
            return View(urun);
        }


    }
}