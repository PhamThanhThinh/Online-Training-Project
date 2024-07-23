using Model.Dao;
using System.Web.Mvc;
using Web.Areas.Admin.Models;
using Web.Common;

namespace Web.Areas.Admin.Controllers
{
  public class LoginController : Controller
  {
    // GET: Admin/Login
    public ActionResult Index()
    {
      return View();
    }
    public ActionResult Login(LoginModel model)
    {
      if (ModelState.IsValid)
      {
        var dao = new UserDao();
        var result = dao.Login(model.UserName, Encryptor.MD5Hash(model.Password), true);
        if (result == 1)
        {
          var user = dao.GetByUserName(model.UserName);
          var usersession = new UserLogin();
          usersession.UserName = user.UserName;
          usersession.UserID = user.ID;
          Session.Add(CommonConstants.USER_SESSION, usersession);
          return RedirectToAction("Index", "Home");
        }
        else if (result == 0)
        {
          ModelState.AddModelError("", "Tài khoản không tồn tai");
        }
        else if (result == -1)
        {
          ModelState.AddModelError("", "Tài khoản đang bị khóa");
        }
        else if (result == -2)
        {
          ModelState.AddModelError("", "Mật khẩu không đúng");
        }
        else if (result == -3)
        {
          ModelState.AddModelError("", "Tài khoản không có quyền đăng nhập");
        }
      }
      return View("Index");
    }
  }
}