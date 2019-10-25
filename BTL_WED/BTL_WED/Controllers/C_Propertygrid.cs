using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTL_WED.Controllers
{
    using BTL_WED.Models.Function;
    using BTL_WED.Models.Emty;
    public class C_Propertygrid : Controller
    {
        // GET: C_Propertygrid
        public ActionResult Propertygrid()
        {

            var model = new F_House().DS_House.ToList();
            ViewBag.Image = new F_Image();
            return View(model);
        }
    }
}