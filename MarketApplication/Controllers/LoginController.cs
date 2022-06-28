using MarketApplication.DbContexts;
using MarketApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MarketApplication.Controllers
{

    [AllowAnonymous]
    public class LoginController : Controller
    {
        public Context db = new Context();


        // GET: Kategori
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string mail, string password)
        {
            var kullanici = db.Kullanici.FirstOrDefault(x => x.Eposta == mail && x.Sifre == password);
            
            if(kullanici != null)
            {

                FormsAuthentication.SetAuthCookie(kullanici.KullaniciId.ToString(), false);
                Session["kullanici"] = kullanici.KullaniciId.ToString();
                return Redirect("/");
            }

            ViewBag.error = "Kullanıcı adı yada parola hatalı.";

            return View();
        }


        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Kullanici kullanici)
        {

            if (ModelState.IsValid)
            {
                db.Kullanici.Add(kullanici);
                db.SaveChanges();
                return Redirect("/login");
            }

            ViewBag.error = "gerekli bilgileri girip tekrar deneyin.";
            return View();
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return Redirect("/login");
        }
    }
}