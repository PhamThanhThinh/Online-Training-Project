using System.ComponentModel.DataAnnotations;

namespace Web.Areas.Admin.Models
{
  public class LoginModel
  {
    [Required(ErrorMessage = "Mời bạn nhập UserName")]
    public string UserName { set; get; }

    [Required(ErrorMessage = "Mời bạn nhập Password")]

    public string Password { set; get; }

    public bool RememberMe { set; get; }
  }
}