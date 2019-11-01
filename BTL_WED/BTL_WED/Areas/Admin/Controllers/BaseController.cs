using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BTL_WED.Common;
namespace BTL_WED.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var sess =(UserID) Session[Constant.UserSession];
            if (sess == null)
            {
                filterContext.Result = new RedirectToRouteResult(new
                   System.Web.Routing.RouteValueDictionary(new { controller = "Login", action = "Login", Area = "Admin" }));
            }
            base.OnActionExecuting(filterContext);
        }
    }
}