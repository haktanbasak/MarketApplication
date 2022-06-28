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
    [Authorize]
    public class BaseController : Controller
    {
        protected Context db;
        protected Kullanici currentUser;
        public BaseController()
        {
            if(db == null)
            {
                db = new Context();
            }
        }

        protected Kullanici GetKullanici(int id)
        {
            return db.Kullanici.Find(id);
        }

    }
}