using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace BTL_WED.Controllers
{
    using BTL_WED.Models.Function;
    using BTL_WED.Models.Emty;
    public class ProfileHouse : Controller
    {
        // GET: Propertysingle
        public ActionResult Propertysingle(int id)
        {
            F_House House = new F_House();
            ViewBag.House = House.FindEntity(id);
            return View("Propertysingle");
        }
    }
}