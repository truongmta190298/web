using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace BTL_WED.Controllers
{
    using BTL_WED.Models.Function;
    using BTL_WED.Models.Emty;
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new F_House().DS_House.ToList();
            ViewBag.Host = new F_Host().DS_Host.ToList();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {


            return View();
        }
        [HttpPost]
        public ActionResult SendMessage(int id , string name, string phone, string email, string message)
        {
            var Customer = new Customer();
            Customer.CustomerID = id;
            Customer.Name = name;
            Customer.Email = email;
            Customer.PhoneNumber = phone;
            Customer.Comment = message;
            var insert = new F_Customer();
            insert.Insert(Customer);
            return View("Contact");
        }
        public ActionResult Agnetsgrid()
        {
            var model = new F_Host().DS_Host.ToList();

            return View(model);
        }
        public ActionResult Agnetsingle()
        {
            ViewBag.Message = "Your Agnetsingle page.";

            return View();
        }

        public ActionResult Propertygrid()
        {

            var model = new F_House().DS_House.ToList();
            return View(model);
        }
        public ActionResult Propertysingle(int id)
        {
            var model = new F_Image().GetImageHouse(id);
            F_House House = new F_House();
            F_Host Host = new F_Host();
            ViewBag.House = House.FindEntity(id);
            ViewBag.Host = Host.FindEntity(id);
            return View(model);
        }
    }
}