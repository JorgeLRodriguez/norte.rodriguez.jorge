using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSiteLPPA.Controllers
{
    public class HTMLController : Controller
    {
        // GET: HTML
        public ActionResult Tablas()
        {
            return View();
        }
        public ActionResult TablasAvanzadas()
        {
            return View();
        }
    }
}