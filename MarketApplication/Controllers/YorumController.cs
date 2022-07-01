using MarketApplication.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace MarketApplication.Controllers
{
    [Authorize]
    public class YorumController : BaseController
    {
        public PartialViewResult MagazaYorumlar(int MagazaId)
        {
            var yorumlar = db.Yorum.Where(x => x.MagazaId == MagazaId).ToList();
            return PartialView(yorumlar);
        }

        public PartialViewResult UrunYorumlar(int UrunId)
        {
            var yorumlar = db.Yorum.Where(x => x.UrunId == UrunId).ToList();
            return PartialView(yorumlar);
        }

        [HttpPost]
        public ActionResult Ekle(Yorum yorum)
        {
            var url = yorum.MagazaId != null ? "/magaza/detay?magazaId=" + yorum.MagazaId : "/urun/detay?Urunid=" + yorum.UrunId;
            yorum.KullaniciId = GetKullanici(Convert.ToInt32(Session["kullanici"])).KullaniciId;
            db.Yorum.Add(yorum);
            db.SaveChanges();
            return Redirect(url);
        }

    }
}