using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BTL_WED.Models.Emty;
using BTL_WED.Models.Function;
namespace BTL_WED.Areas.Admin.Controllers
{
    public class CustomerController : BaseController
    {
        // GET: Admin/Customer
        public ActionResult ShowAll()
        {
            MyDBContext context = new MyDBContext();
            ViewBag.Customer = context.Customers.ToList();
            return View();
        }
    }
}