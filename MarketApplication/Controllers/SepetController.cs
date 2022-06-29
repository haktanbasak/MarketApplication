using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarketApplication.Controllers
{
    
    public class SepetController : BaseController
    {
        // GET: Siparis
        public ActionResult Index()
        {
            var model = db.Sepet.Include("Urun").ToList();
            return View(model);
        }
    }
}