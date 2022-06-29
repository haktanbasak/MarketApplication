using MarketApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarketApplication.Controllers
{
    
    public class SaticiController : BaseController
    {
        // GET: Siparis
        Satici satici;
        public SaticiController()
        {
           

        }
        public ActionResult Index()
        {
            int sId = Convert.ToInt32(Session["satici"]);
            satici = db.Satici.Find(sId);

            ViewBag.satici = satici.SaticiId;
            return View();
        }

        public ActionResult Siparisler()
        {
            var siparisler = db.Siparis
                .Include("siparisStatu")
                .Include("Kullanici")
                .Include("Satici")
                .Include("Satici.Magaza")
                .Include("Sepetler")
                .Where(x => x.SaticiId == 1);
            return View(siparisler);
        }
    }
}