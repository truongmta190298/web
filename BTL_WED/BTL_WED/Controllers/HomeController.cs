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


        [HttpPost]
        public ActionResult F_Search(string Keyword, string Type, string City,string Bedrooms,string Garages, string Bathrooms, string Price)
        {
            var model = new List<House>();
            if(Type=="All Type")
            {
                if(City=="All City")
                {
                    model = new F_House().DS_House.Where(x => x.PropertyDescription.Contains(Keyword) || x.Location.Contains(Keyword) || x.PropertyType.Contains(Keyword)).ToList();
 
                }
                else
                {
                    model = new F_House().DS_House.Where(x =>x.Location.Contains(City)&&(x.PropertyDescription.Contains(Keyword) || x.Location.Contains(Keyword) || x.PropertyType.Contains(Keyword))).ToList();
                }
            }
            else
            {
                if (City == "All City")
                {
                    model = new F_House().DS_House.Where(x =>x.PropertyType.Contains(Type)&&(x.PropertyDescription.Contains(Keyword) || x.Location.Contains(Keyword) || x.PropertyType.Contains(Keyword))).ToList();

                }
                else
                {
                    model = new F_House().DS_House.Where(x =>x.PropertyType.Contains(Type)&&x.Location.Contains(City) && (x.PropertyDescription.Contains(Keyword) || x.Location.Contains(Keyword) || x.PropertyType.Contains(Keyword))).ToList();
                }
            }
            List<House> temp = new List<House>(model);
            int Bed=0, Bath=0, Gar=0;
            Int32.TryParse(Bedrooms, out Bed);
            Int32.TryParse(Bathrooms,out Bath);
            Int32.TryParse(Garages,out Gar);
            if(Bed>0) for(int i = 0; i < temp.Count; i++)
                {
                    if (temp[i].Beds != Bed) temp.Remove(temp[i]);
                }
            if (Bath > 0) for (int i = 0; i < temp.Count; i++)
                {
                    if (temp[i].Baths != Bath) temp.Remove(temp[i]);
                }
            if (Gar > 0) for (int i = 0; i < temp.Count; i++)
                {
                    if (temp[i].Garage != Gar) temp.Remove(temp[i]);
                }
            if(Price== "Below $100,000") for (int i = 0; i < temp.Count; i++)
                {
                    if (temp[i].Price >=100000 ) temp.Remove(temp[i]);
                }
            if (Price == "$100,000 - $250,000") for (int i = 0; i < temp.Count; i++)
                {
                    if (temp[i].Price < 100000|| temp[i].Price >= 250000) temp.Remove(temp[i]);
                }
            if (Price == "$250,000 - $500,000") for (int i = 0; i < temp.Count; i++)
                {
                    if (temp[i].Price < 250000 || temp[i].Price >= 500000) temp.Remove(temp[i]);
                }
            if (Price == "Over $500,000") for (int i = 0; i < temp.Count; i++)
                {
                    if (temp[i].Price < 500000) temp.Remove(temp[i]);
                }
            ViewBag.Host = new F_Host().DS_Host.ToList();
            return View("Index",temp);
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
        public ActionResult SendMessage(string name, string phone, string email, string message)
        {
            var Customer = new Customer();
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
        public ActionResult Agnetsingle(int id)
        {
            var model = new F_House().DS_House.ToList();
            F_Host Host = new F_Host();
            ViewBag.Host = Host.FindEntity(id);
            return View(model);
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