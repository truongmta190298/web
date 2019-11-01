using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BTL_WED.Models.Emty;
using BTL_WED.Models.Function;
using BTL_WED.Common;
namespace BTL_WED.Areas.Admin.Controllers

{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginResult(Accout ac)
        {
            MyDBContext context = new MyDBContext();
            
            if(ModelState.IsValid ) //&& account.Pass.Contains(ac.Pass)
            {
                Accout account = context.Accouts.SingleOrDefault(user => user.UserName.Contains(ac.UserName));
                if(account != null && account.Pass.Contains(ac.Pass))
                {
                    var userSession = new UserID();
                    userSession.UserName = account.UserName;
                    Session.Add(Constant.UserSession, userSession);
                    return RedirectToAction("Index", "Main");

                }
                //return View("~/Areas/Admin/Views/Main/Index.cshtml");             
            }             
            return View("Login");
            //acount == null || ac.UserName.Contains(account.Pass)
        }
        
    }
}