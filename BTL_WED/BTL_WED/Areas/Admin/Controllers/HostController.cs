using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BTL_WED.Models.Function;
using BTL_WED.Models.Emty;
namespace BTL_WED.Areas.Admin.Controllers
{
    public class HostController : BaseController
    {
        static int HostID = 0;
        // GET: Admin/Host
        public List<Host> GetHost()
        {
            return new F_Host().DS_Host.ToList();
        }
        public ActionResult ShowAll()
        {
            var host = GetHost();
            return View(host);
        }

        public ActionResult Change(int ID)
        {
            HostID = ID;
            var host = new F_Host().FindEntity(ID);
            return View(host);
        }
        public ActionResult ListHouse(int? ID)
        {
            MyDBContext context = new MyDBContext();
            var model = context.Houses.Where(house => house.HostID==ID).ToList();
            return View(model);
        }
        public ActionResult Delete(int? ID)
        {
            MyDBContext context = new MyDBContext();
            int? x = new F_Host().Delete(ID);
            var host = GetHost();
            return View("~/Areas/Admin/Views/Host/ShowAll.cshtml", host);
        }
        [HttpPost]
        public ActionResult AddHost(Host host)
        {
            host.HostID = HostID;
            var x = new F_Host().Update(host);
            var model = GetHost();
            return View("~/Areas/Admin/Views/Host/ShowAll.cshtml", model);
        }
    }
}