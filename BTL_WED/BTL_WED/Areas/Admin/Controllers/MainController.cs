using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BTL_WED.Models.Emty;
using BTL_WED.Models.Function;
namespace BTL_WED.Areas.Admin.Controllers
{
    public class MainController : BaseController
    {
        // GET: Admin/Main
        MyDBContext context = new MyDBContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ControlAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ReturnAdmin(string UserName,string Pass)
        {
            F_Accout f_account = new F_Accout();
            if (f_account.FindEntity(UserName)==null)
            {
                ModelState.AddModelError("", "Thêm tài khoản thành công");
                Accout ac = new Accout();
                ac.UserName = UserName;
                ac.Pass = Pass;
                f_account.Insert(ac);
            }
            else
            {
                ModelState.AddModelError("", "Tài khoản đã tồn tại");
            }
            return View("ControlAdmin");
        }

        public ActionResult TableAdmin()
        {
            MyDBContext context = new MyDBContext();
            List<Accout> model = context.Accouts.ToList();
            return View(model);
        }
        
        public ActionResult ChangeAccount(string UserName)
        {
            F_Accout f_account = new F_Accout();
            f_account.Delete(UserName);
            ViewBag.delete = UserName;
            return View();
            MyDBContext context = new MyDBContext();
            List<Accout> model = context.Accouts.ToList();
            return View("TableAdmin",model);
        }



    }
}