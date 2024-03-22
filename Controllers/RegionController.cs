using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    //bug fixee une autre fois
    public class RegionController : Controller
    {
        // GET: Region c est le bug a fixé!!
        public ActionResult Index()
        {
            return View();
        }
    }
}