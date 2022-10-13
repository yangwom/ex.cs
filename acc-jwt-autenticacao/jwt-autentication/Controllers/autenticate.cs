using Microsoft.AspNetCore.Mvc;
using Auth.Models;
using Auth.ViewModels;

namespace jwt_autentication.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    [HttpPost]

    public ActionResult<UserViewModel> Authenticate([FromBody] User User)
    {
      UserViewModel userViewModel = new UserViewModel();
      try
      {

      }
      catch
      {

      }
      return userViewModel;
    }
}
