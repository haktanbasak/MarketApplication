using MarketApplication.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarketApplication.Controllers
{
    public class BaseController : Controller
    {
        protected Context db;
        public BaseController()
        {
            if(db == null)
            {
                db = new Context();
            }
        }
    }
}