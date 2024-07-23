using System.Web.Mvc;
using System.Web.Routing;
using Web.Common;

namespace Web.Areas.Admin.Controllers
{
  public class BaseController : Controller
  {
    protected override void OnActionExecuting(ActionExecutingContext filterContext)
    {
      var session = (UserLogin)Session[CommonConstants.USER_SESSION];
      if (session == null)
      {
        filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Login", action = "Index", Area = "Admin" }));
      }
      else
          if (session.UserName.ToLower() != "admin")
      {
        filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Login", action = "Index", Area = "Admin" }));
      }

      base.OnActionExecuting(filterContext);
    }
    protected void SetAlert(string message, string type)
    {
      TempData["AlertMessage"] = message;
      if (type == "success")
      {
        TempData["AlertType"] = "alert-success";
      }
      if (type == "warning")
      {
        TempData["AlertType"] = "alert-warning";
      }
      if (type == "success")
      {
        TempData["error"] = "alert-danger";
      }
    }
  }
}